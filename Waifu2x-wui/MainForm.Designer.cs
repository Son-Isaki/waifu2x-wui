namespace Waifu2xWui
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			groupBox1 = new GroupBox();
			label2 = new Label();
			sourceFilenameField = new TextBox();
			browseButton = new Button();
			label1 = new Label();
			groupBox2 = new GroupBox();
			dataGridView1 = new DataGridView();
			Active = new DataGridViewCheckBoxColumn();
			Width = new DataGridViewTextBoxColumn();
			Noise = new DataGridViewComboBoxColumn();
			Extension = new DataGridViewComboBoxColumn();
			Suffix = new DataGridViewTextBoxColumn();
			generateButton = new Button();
			progressBar1 = new ProgressBar();
			groupBox3 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			label7 = new Label();
			modelField = new ComboBox();
			label6 = new Label();
			numericUpDown1 = new NumericUpDown();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			noiseField = new ComboBox();
			domainUpDown2 = new DomainUpDown();
			deviceField = new ComboBox();
			splitContainer1 = new SplitContainer();
			richTextBox1 = new RichTextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox3.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(sourceFilenameField);
			groupBox1.Controls.Add(browseButton);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(699, 76);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Source";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(145, 48);
			label2.Name = "label2";
			label2.Size = new Size(54, 15);
			label2.TabIndex = 8;
			label2.Text = "File infos";
			// 
			// sourceFilenameField
			// 
			sourceFilenameField.AllowDrop = true;
			sourceFilenameField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			sourceFilenameField.Location = new Point(145, 22);
			sourceFilenameField.Name = "sourceFilenameField";
			sourceFilenameField.Size = new Size(444, 23);
			sourceFilenameField.TabIndex = 2;
			sourceFilenameField.TextChanged += OnProfileUpdated;
			// 
			// browseButton
			// 
			browseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			browseButton.Location = new Point(595, 22);
			browseButton.Name = "browseButton";
			browseButton.Size = new Size(98, 23);
			browseButton.TabIndex = 1;
			browseButton.Text = "Browse";
			browseButton.UseVisualStyleBackColor = true;
			browseButton.MouseClick += SelectSourceFile;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(6, 26);
			label1.Name = "label1";
			label1.Size = new Size(79, 15);
			label1.TabIndex = 0;
			label1.Text = "Source image";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dataGridView1);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(0, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(333, 173);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Outputs";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = SystemColors.Control;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Active, Width, Noise, Extension, Suffix });
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 19);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
			dataGridView1.Size = new Size(327, 151);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellValueChanged += OnProfileUpdated;
			// 
			// Active
			// 
			Active.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			Active.DataPropertyName = "enabled";
			Active.FillWeight = 81.21828F;
			Active.FlatStyle = FlatStyle.System;
			Active.HeaderText = "Active";
			Active.Name = "Active";
			Active.Resizable = DataGridViewTriState.False;
			Active.Width = 50;
			// 
			// Width
			// 
			Width.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Width.DataPropertyName = "width";
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			Width.DefaultCellStyle = dataGridViewCellStyle1;
			Width.FillWeight = 106.260582F;
			Width.HeaderText = "Width";
			Width.Name = "Width";
			// 
			// Noise
			// 
			Noise.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Noise.DataPropertyName = "Noise";
			Noise.FlatStyle = FlatStyle.Flat;
			Noise.HeaderText = "Noise reduction";
			Noise.Items.AddRange(new object[] { "1", "2", "3" });
			Noise.Name = "Noise";
			// 
			// Extension
			// 
			Extension.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Extension.DataPropertyName = "extension";
			Extension.FillWeight = 106.260582F;
			Extension.FlatStyle = FlatStyle.Flat;
			Extension.HeaderText = "Extension";
			Extension.Items.AddRange(new object[] { "png", "jpg", "jpeg", "webp" });
			Extension.Name = "Extension";
			// 
			// Suffix
			// 
			Suffix.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Suffix.DataPropertyName = "suffix";
			Suffix.FillWeight = 106.260582F;
			Suffix.HeaderText = "Suffix";
			Suffix.Name = "Suffix";
			// 
			// generateButton
			// 
			generateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			generateButton.Location = new Point(607, 331);
			generateButton.Name = "generateButton";
			generateButton.Size = new Size(104, 23);
			generateButton.TabIndex = 2;
			generateButton.Text = "Generate !";
			generateButton.UseVisualStyleBackColor = true;
			generateButton.MouseClick += Generate;
			// 
			// progressBar1
			// 
			progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			progressBar1.Location = new Point(607, 302);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(104, 23);
			progressBar1.Step = 1;
			progressBar1.TabIndex = 4;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(tableLayoutPanel1);
			groupBox3.Dock = DockStyle.Fill;
			groupBox3.Location = new Point(0, 0);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(362, 173);
			groupBox3.TabIndex = 6;
			groupBox3.TabStop = false;
			groupBox3.Text = "Configuration";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(label7, 0, 4);
			tableLayoutPanel1.Controls.Add(modelField, 1, 0);
			tableLayoutPanel1.Controls.Add(label6, 0, 3);
			tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 3);
			tableLayoutPanel1.Controls.Add(label5, 0, 2);
			tableLayoutPanel1.Controls.Add(label4, 0, 1);
			tableLayoutPanel1.Controls.Add(label3, 0, 0);
			tableLayoutPanel1.Controls.Add(noiseField, 1, 1);
			tableLayoutPanel1.Controls.Add(domainUpDown2, 1, 2);
			tableLayoutPanel1.Controls.Add(deviceField, 1, 4);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 19);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.Size = new Size(356, 151);
			tableLayoutPanel1.TabIndex = 14;
			// 
			// label7
			// 
			label7.Dock = DockStyle.Fill;
			label7.Location = new Point(3, 123);
			label7.Margin = new Padding(3);
			label7.Name = "label7";
			label7.Size = new Size(114, 25);
			label7.TabIndex = 19;
			label7.Text = "Device";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// modelField
			// 
			modelField.Dock = DockStyle.Top;
			modelField.FormattingEnabled = true;
			modelField.Location = new Point(123, 3);
			modelField.Name = "modelField";
			modelField.Size = new Size(230, 23);
			modelField.TabIndex = 14;
			modelField.SelectedValueChanged += OnProfileUpdated;
			// 
			// label6
			// 
			label6.Dock = DockStyle.Fill;
			label6.Location = new Point(3, 93);
			label6.Margin = new Padding(3);
			label6.Name = "label6";
			label6.Size = new Size(114, 24);
			label6.TabIndex = 18;
			label6.Text = "Batch size";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Dock = DockStyle.Top;
			numericUpDown1.Location = new Point(123, 93);
			numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(230, 23);
			numericUpDown1.TabIndex = 12;
			numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown1.ValueChanged += OnProfileUpdated;
			// 
			// label5
			// 
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(3, 63);
			label5.Margin = new Padding(3);
			label5.Name = "label5";
			label5.Size = new Size(114, 24);
			label5.TabIndex = 17;
			label5.Text = "Split size";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 33);
			label4.Margin = new Padding(3);
			label4.Name = "label4";
			label4.Size = new Size(114, 24);
			label4.TabIndex = 16;
			label4.Text = "Noise reduction";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 3);
			label3.Margin = new Padding(3);
			label3.Name = "label3";
			label3.Size = new Size(114, 24);
			label3.TabIndex = 11;
			label3.Text = "Model";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// noiseField
			// 
			noiseField.Dock = DockStyle.Top;
			noiseField.FormattingEnabled = true;
			noiseField.Items.AddRange(new object[] { "1", "2", "3" });
			noiseField.Location = new Point(123, 33);
			noiseField.Name = "noiseField";
			noiseField.Size = new Size(230, 23);
			noiseField.TabIndex = 15;
			noiseField.SelectedValueChanged += OnProfileUpdated;
			// 
			// domainUpDown2
			// 
			domainUpDown2.Dock = DockStyle.Top;
			domainUpDown2.Items.Add("64");
			domainUpDown2.Items.Add("128");
			domainUpDown2.Items.Add("256");
			domainUpDown2.Items.Add("512");
			domainUpDown2.Location = new Point(123, 63);
			domainUpDown2.Name = "domainUpDown2";
			domainUpDown2.Size = new Size(230, 23);
			domainUpDown2.TabIndex = 13;
			domainUpDown2.Text = "128";
			domainUpDown2.SelectedItemChanged += OnProfileUpdated;
			// 
			// deviceField
			// 
			deviceField.Dock = DockStyle.Top;
			deviceField.FormattingEnabled = true;
			deviceField.Location = new Point(123, 123);
			deviceField.Name = "deviceField";
			deviceField.Size = new Size(230, 23);
			deviceField.TabIndex = 20;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.Location = new Point(12, 94);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(groupBox2);
			splitContainer1.Panel1.RightToLeft = RightToLeft.No;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(groupBox3);
			splitContainer1.Panel2.RightToLeft = RightToLeft.No;
			splitContainer1.Size = new Size(699, 173);
			splitContainer1.SplitterDistance = 333;
			splitContainer1.TabIndex = 7;
			// 
			// richTextBox1
			// 
			richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			richTextBox1.BackColor = Color.Black;
			richTextBox1.BorderStyle = BorderStyle.None;
			richTextBox1.Font = new Font("DejaVu Sans Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBox1.ForeColor = SystemColors.Info;
			richTextBox1.Location = new Point(12, 273);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
			richTextBox1.Size = new Size(589, 81);
			richTextBox1.TabIndex = 8;
			richTextBox1.Text = "";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(723, 365);
			Controls.Add(richTextBox1);
			Controls.Add(progressBar1);
			Controls.Add(splitContainer1);
			Controls.Add(generateButton);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			RightToLeft = RightToLeft.No;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "waifu2x-wui";
			Load += OnLoad;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox3.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox sourceFilenameField;
		private Button browseButton;
		private Label label1;
		private GroupBox groupBox2;
		private DataGridView dataGridView1;
		private Button generateButton;
		private ProgressBar progressBar1;
		private GroupBox groupBox3;
		private SplitContainer splitContainer1;
		private Label label2;
		private DomainUpDown domainUpDown2;
		private NumericUpDown numericUpDown1;
		private RichTextBox richTextBox1;
		private ComboBox modelField;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label3;
		private Label label6;
		private Label label5;
		private DataGridViewCheckBoxColumn Active;
		private DataGridViewTextBoxColumn Width;
		private DataGridViewComboBoxColumn Noise;
		private DataGridViewComboBoxColumn Extension;
		private DataGridViewTextBoxColumn Suffix;
		private Label label7;
		private ComboBox deviceField;
		private Label label4;
		private ComboBox noiseField;
	}
}