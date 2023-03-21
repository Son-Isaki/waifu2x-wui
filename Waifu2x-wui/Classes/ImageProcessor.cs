using System.Diagnostics;
using static Waifu2xWui.MainForm;
using System.Windows.Forms;
using Waifu2xWeb;

namespace Waifu2xWui
{
	public class ImageProcessor
	{
		public const string LIB_PATH = @"Resources\waifu2x-caffe\waifu2x-caffe-cui.exe";
		public const string MODELS_PATH = @"Resources\waifu2x-caffe\models";

		public int SourceWidth { get; set; } = 0;

		public Profile Profile { get; set; } = new Profile();

		private Process process;
		private int processIndex = 0;

		public Action<OutputFile> OnImageProcessed;

		public void Start()
		{
			PrepareProcess();
			ProcessNext();
		}

		private void PrepareProcess()
		{
			processIndex = 0;
		}

		private void ProcessNext()
		{
			if (!HasOutputFileToProcess())
				return;

			OutputFile output = Profile.OutputFiles[processIndex];

			if (
				!output.IsActive ||
				output.CompareWithSourceFilename(Profile.SourceFilename)
			)
			{
				Logger.Log($"Can't process {output.GetOutputFilename(Profile.SourceFilename)} because the output filename is the same as the original file.", LogType.Warning);
				processIndex++;
				ProcessNext();
				return;
			}

			var outputFilename = output.GetOutputFilename(Profile.SourceFilename);
			var scale = (float)output.Width / (float)SourceWidth;
			var fScale = string.Format("{0:#.000000}", scale).Replace(",", ".");
			var commandArguments =
				$"-i \"{Profile.SourceFilename}\" " +
				$"-o \"{outputFilename}\" " +
				$"--scale_ratio {fScale} " +
				$"-m noise_scale " +
				$"--noise_level {Profile.NoiseReduction} " +
				$"--model_dir models/{Profile.Model} " +
				$"-p {Profile.Device.ToString().ToLower()} " +
				$"-t 0";

			//Logger.Log(commandArguments);

			ProcessCommand(commandArguments);
		}

		private bool HasOutputFileToProcess()
		{
			return (
				processIndex >= 0 &&
				processIndex < Profile.OutputFiles.Count
			);
		}

		private void ProcessCommand(string processArguments)
		{
			// Simple checks before further execution
			if (!File.Exists(LIB_PATH))
			{
				MessageBox.Show($"{LIB_PATH} is missing!");
				return;
			}
			if (!Directory.Exists(MODELS_PATH))
			{
				MessageBox.Show("Training model folder is missing!");
				return;
			}

			process = new Process();

			ProcessStartInfo info = new ProcessStartInfo
			{
				FileName = Path.Combine(AppContext.BaseDirectory, LIB_PATH),
				Arguments = processArguments,
				RedirectStandardError = true,
				RedirectStandardInput = true,
				RedirectStandardOutput = true,
				UseShellExecute = false,
				WorkingDirectory = AppContext.BaseDirectory,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};

			process.StartInfo = info;
			process.EnableRaisingEvents = true;
			process.Exited += new EventHandler(OnProcessExit);

			try
			{
				bool state = process.Start();
				process.WaitForExit();
			}
			catch (Exception ex)
			{
				process.Kill();
				Logger.Log(ex.ToString(), LogType.Error);
			}
		}

		private void OnProcessExit(object? sender, EventArgs e)
		{
			process.Close();

			OnImageProcessed?.Invoke(Profile.OutputFiles[processIndex]);

			processIndex++;
			ProcessNext();
		}
	}
}