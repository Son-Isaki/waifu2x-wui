using Microsoft.VisualBasic.Logging;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using Waifu2xWeb;

namespace Waifu2xWui
{
	public partial class MainForm : Form
	{

		public static MainForm? Instance;

		public readonly string[] ALLOWED_EXTENSIONS = { "png", "jpg", "jpeg", "webp", "tif", "tiff", "bmp", "tga" };

		private string GetExtensionsForDialog()
		{
			return string.Join(';', ALLOWED_EXTENSIONS.Select(v => "*." + v));
		}

		readonly ImageProcessor processor;
		readonly FileDropper fileDropper;
		readonly ProfileManager profileManager;

		int sourceWidth = 0;
		bool loaded = false;

		public MainForm()
		{
			InitializeComponent();

			// singleton
			Instance = this;
			Logger.SetConsole(richTextBox1);

			fileDropper = new FileDropper(this);
			processor = new ImageProcessor();
			profileManager = new ProfileManager();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			// load the profile
			var profile = profileManager.Load(ProfileManager.FILENAME);
			if (profile == null)
			{
				profile = new Profile();
				profile.SetDefaults();
				Logger.Log($"No profile found", LogType.Warning);
			}

			// initialize the file dropper
			fileDropper.OnFileDropped += (filepath) => SelectSourceFile(filepath);
			fileDropper.Initialize();

			// initialize the processor
			processor.Profile = profile;
			processor.OnImageProcessed += (OutputFile outputFile) =>
			{
				progressBar1.PerformStep();
				Logger.Log($"{outputFile.GetOutputFilename(processor.Profile.SourceFilename)} has been processed", LogType.Success);
			};

			// initialize form and fields
			SetupFields();
			SetupProfile(profile);

			// update the source infos label
			GetSourceFileInfos(profile.SourceFilename);

			loaded = true;
		}

		private void InitializeAllowedExtensions()
		{
			var extensionColumn = ((DataGridViewComboBoxColumn)dataGridView1.Columns[3]);
			extensionColumn.Items.Clear();
			extensionColumn.Items.AddRange(ALLOWED_EXTENSIONS);
		}

		private void InitializeDevices()
		{
			deviceField.Items.Clear();
			deviceField.Items.AddRange(Enum.GetNames<Device>());
		}

		private void SetupFields()
		{
			InitializeModels();
			InitializeAllowedExtensions();
			InitializeDevices();
		}

		private void SetupProfile(Profile profile)
		{
			// fill the datagridview rows
			dataGridView1.Rows.Clear();
			foreach (var o in profile.OutputFiles)
			{
				AddOutputRow(o.IsActive, o.Width, o.NoiseReduction, o.Extension, o.Suffix);
			}

			modelField.SelectedValue = profile.Model;
			noiseField.SelectedValue = profile.NoiseReduction;
			noiseField.Text = profile.NoiseReduction.ToString();
			deviceField.Text = profile.Device.ToString();
			sourceFilenameField.Text = profile.SourceFilename;
			modelField.Text = profile.Model;
		}

		private void InitializeModels()
		{
			var models = new Dictionary<string, string>();
			foreach (var folder in Directory.GetDirectories(ImageProcessor.MODELS_PATH))
			{
				var modelName = Path.GetFileName(folder);
				models.Add(modelName, modelName);
			}
			modelField.DataSource = models.ToList();
			modelField.ValueMember = "Key";
			modelField.DisplayMember = "Value";
		}

		private void AddOutputRow(bool active, int width, int noise, string extension, string suffix)
		{
			dataGridView1.Rows.Add(active, width, noise.ToString(), extension, suffix);
		}

		private void SelectSourceFile(object sender, MouseEventArgs e)
		{
			var openFile = new OpenFileDialog
			{
				Filter = "Images|" + GetExtensionsForDialog(),
				Multiselect = false
			};

			if (sourceFilenameField.Text.Trim().Length > 0)
			{
				openFile.InitialDirectory = sourceFilenameField.Text;
			}
			else
			{
				openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			}

			if (openFile.ShowDialog() == DialogResult.OK)
			{
				SelectSourceFile(openFile.FileName);
			}
		}

		public void SelectSourceFile(string filepath)
		{
			if (!File.Exists(filepath))
			{
				Logger.Log($"The file {filepath} does not exists", LogType.Error);
				return;
			}

			var extension = Path.GetExtension(filepath).Trim('.').ToLower();

			if (!ALLOWED_EXTENSIONS.Contains(extension))
			{
				Logger.Log($"The file extension {extension} is not allowed", LogType.Error);
				return;
			}

			sourceFilenameField.Text = filepath;
			GetSourceFileInfos(filepath);
		}

		private void Generate(object sender, MouseEventArgs e)
		{
			if (!File.Exists(processor.Profile.SourceFilename))
			{
				Logger.Log($"The file {processor.Profile.SourceFilename} does not exists");
				return;
			}

			// progressbar
			progressBar1.Value = 0;
			progressBar1.Maximum = processor.Profile.OutputFiles.Count;

			// source width
			processor.SourceWidth = sourceWidth;

			// process images
			processor.Start();
		}

		private void GetSourceFileInfos(string filepath)
		{
			if (!File.Exists(filepath))
			{
				label2.Text = string.Empty;
				return;
			}

			FileInfo infos = new(filepath);
			Bitmap img = new(filepath);

			sourceWidth = img.Width;
			label2.Text = $"Width: {img.Width} | Height: {img.Height} | Extension: {infos.Extension}";

			img.Dispose();
		}

		private void SaveProfile()
		{
			if (!loaded)
				return;

			profileManager.Save(processor.Profile, ProfileManager.FILENAME);
		}

		private void UpdateProfile()
		{
			if (!loaded)
				return;

			// filename
			processor.Profile.SourceFilename = sourceFilenameField.Text.Trim();

			// model
			processor.Profile.Model = modelField.Text;

			// noise
			if (int.TryParse(noiseField.Text, out int noise))
			{
				processor.Profile.NoiseReduction = noise;
			}

			// device
			Enum.TryParse<Device>(deviceField.Text.ToString(), true, out Device device);
			processor.Profile.Device = device;

			// output files
			var outputs = new List<OutputFile>();
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.IsNewRow)
					continue;

				if (row.Cells.Count < dataGridView1.ColumnCount)
					continue;

				/*if (row.Cells[0].Value == null || !(bool)row.Cells[0].Value)
					continue;*/

				var output = new OutputFile()
				{
					Extension = row.Cells[3].Value?.ToString(),
					Suffix = row.Cells[4].Value?.ToString(),
				};

				if (int.TryParse(row.Cells[1].Value?.ToString(), out int width))
				{
					output.Width = width;
				}
				if (int.TryParse(row.Cells[2].Value?.ToString(), out int noiseReduction))
				{
					output.NoiseReduction = noiseReduction;
				}
				outputs.Add(output);
			}
			processor.Profile.OutputFiles = outputs;
		}

		private void OnProfileUpdated(object sender, EventArgs e)
		{
			UpdateProfile();
			SaveProfile();
		}

		private void OnProfileUpdated(object sender, DataGridViewCellEventArgs e)
		{
			UpdateProfile();
			SaveProfile();
		}
	}
}