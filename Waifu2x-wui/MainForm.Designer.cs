﻿namespace Waifu2xWui
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			splitContainer1 = new SplitContainer();
			groupBox2 = new GroupBox();
			dataGridView1 = new DataGridView();
			Active = new DataGridViewCheckBoxColumn();
			Width = new DataGridViewTextBoxColumn();
			Noise = new DataGridViewComboBoxColumn();
			Extension = new DataGridViewComboBoxColumn();
			Suffix = new DataGridViewTextBoxColumn();
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
			groupBox1 = new GroupBox();
			label2 = new Label();
			sourceFilenameField = new TextBox();
			browseButton = new Button();
			label1 = new Label();
			generateButton = new Button();
			progressBar1 = new ProgressBar();
			richTextBox1 = new RichTextBox();
			language = new ComboBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox3.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			resources.ApplyResources(splitContainer1, "splitContainer1");
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
			splitContainer1.Panel1.Controls.Add(groupBox2);
			// 
			// splitContainer1.Panel2
			// 
			resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
			splitContainer1.Panel2.Controls.Add(groupBox3);
			// 
			// groupBox2
			// 
			resources.ApplyResources(groupBox2, "groupBox2");
			groupBox2.Controls.Add(dataGridView1);
			groupBox2.Name = "groupBox2";
			groupBox2.TabStop = false;
			// 
			// dataGridView1
			// 
			resources.ApplyResources(dataGridView1, "dataGridView1");
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = SystemColors.Control;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Active, Width, Noise, Extension, Suffix });
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
			dataGridView1.CellValueChanged += OnProfileUpdated;
			// 
			// Active
			// 
			Active.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			Active.DataPropertyName = "enabled";
			Active.FillWeight = 81.21828F;
			Active.FlatStyle = FlatStyle.System;
			resources.ApplyResources(Active, "Active");
			Active.Name = "Active";
			Active.Resizable = DataGridViewTriState.False;
			// 
			// Width
			// 
			Width.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Width.DataPropertyName = "width";
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			Width.DefaultCellStyle = dataGridViewCellStyle1;
			Width.FillWeight = 106.260582F;
			resources.ApplyResources(Width, "Width");
			Width.Name = "Width";
			// 
			// Noise
			// 
			Noise.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Noise.DataPropertyName = "Noise";
			Noise.FlatStyle = FlatStyle.Flat;
			resources.ApplyResources(Noise, "Noise");
			Noise.Items.AddRange(new object[] { "1", "2", "3" });
			Noise.Name = "Noise";
			// 
			// Extension
			// 
			Extension.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Extension.DataPropertyName = "extension";
			Extension.FillWeight = 106.260582F;
			Extension.FlatStyle = FlatStyle.Flat;
			resources.ApplyResources(Extension, "Extension");
			Extension.Items.AddRange(new object[] { "png", "jpg", "jpeg", "webp" });
			Extension.Name = "Extension";
			// 
			// Suffix
			// 
			Suffix.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Suffix.DataPropertyName = "suffix";
			Suffix.FillWeight = 106.260582F;
			resources.ApplyResources(Suffix, "Suffix");
			Suffix.Name = "Suffix";
			// 
			// groupBox3
			// 
			resources.ApplyResources(groupBox3, "groupBox3");
			groupBox3.Controls.Add(tableLayoutPanel1);
			groupBox3.Name = "groupBox3";
			groupBox3.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
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
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// label7
			// 
			resources.ApplyResources(label7, "label7");
			label7.Name = "label7";
			// 
			// modelField
			// 
			resources.ApplyResources(modelField, "modelField");
			modelField.FormattingEnabled = true;
			modelField.Name = "modelField";
			modelField.SelectedValueChanged += OnProfileUpdated;
			// 
			// label6
			// 
			resources.ApplyResources(label6, "label6");
			label6.Name = "label6";
			// 
			// numericUpDown1
			// 
			resources.ApplyResources(numericUpDown1, "numericUpDown1");
			numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown1.ValueChanged += OnProfileUpdated;
			// 
			// label5
			// 
			resources.ApplyResources(label5, "label5");
			label5.Name = "label5";
			// 
			// label4
			// 
			resources.ApplyResources(label4, "label4");
			label4.Name = "label4";
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.Name = "label3";
			// 
			// noiseField
			// 
			resources.ApplyResources(noiseField, "noiseField");
			noiseField.FormattingEnabled = true;
			noiseField.Items.AddRange(new object[] { resources.GetString("noiseField.Items"), resources.GetString("noiseField.Items1"), resources.GetString("noiseField.Items2") });
			noiseField.Name = "noiseField";
			noiseField.SelectedValueChanged += OnProfileUpdated;
			// 
			// domainUpDown2
			// 
			resources.ApplyResources(domainUpDown2, "domainUpDown2");
			domainUpDown2.Items.Add(resources.GetString("domainUpDown2.Items"));
			domainUpDown2.Items.Add(resources.GetString("domainUpDown2.Items1"));
			domainUpDown2.Items.Add(resources.GetString("domainUpDown2.Items2"));
			domainUpDown2.Items.Add(resources.GetString("domainUpDown2.Items3"));
			domainUpDown2.Name = "domainUpDown2";
			domainUpDown2.SelectedItemChanged += OnProfileUpdated;
			// 
			// deviceField
			// 
			resources.ApplyResources(deviceField, "deviceField");
			deviceField.FormattingEnabled = true;
			deviceField.Name = "deviceField";
			// 
			// groupBox1
			// 
			resources.ApplyResources(groupBox1, "groupBox1");
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(sourceFilenameField);
			groupBox1.Controls.Add(browseButton);
			groupBox1.Controls.Add(label1);
			groupBox1.Name = "groupBox1";
			groupBox1.TabStop = false;
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// sourceFilenameField
			// 
			resources.ApplyResources(sourceFilenameField, "sourceFilenameField");
			sourceFilenameField.AllowDrop = true;
			sourceFilenameField.Name = "sourceFilenameField";
			sourceFilenameField.TextChanged += OnProfileUpdated;
			// 
			// browseButton
			// 
			resources.ApplyResources(browseButton, "browseButton");
			browseButton.Name = "browseButton";
			browseButton.UseVisualStyleBackColor = true;
			browseButton.MouseClick += SelectSourceFile;
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// generateButton
			// 
			resources.ApplyResources(generateButton, "generateButton");
			generateButton.Name = "generateButton";
			generateButton.UseVisualStyleBackColor = true;
			generateButton.MouseClick += Generate;
			// 
			// progressBar1
			// 
			resources.ApplyResources(progressBar1, "progressBar1");
			progressBar1.Name = "progressBar1";
			progressBar1.Step = 1;
			// 
			// richTextBox1
			// 
			resources.ApplyResources(richTextBox1, "richTextBox1");
			richTextBox1.BackColor = Color.Black;
			richTextBox1.BorderStyle = BorderStyle.None;
			richTextBox1.ForeColor = SystemColors.Info;
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			// 
			// language
			// 
			resources.ApplyResources(language, "language");
			language.FormattingEnabled = true;
			language.Name = "language";
			language.SelectedValueChanged += OnLanguageChanged;
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(language);
			Controls.Add(richTextBox1);
			Controls.Add(progressBar1);
			Controls.Add(splitContainer1);
			Controls.Add(generateButton);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "MainForm";
			Load += OnLoad;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox3.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
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
		private Label label7;
		private ComboBox deviceField;
		private Label label4;
		private ComboBox noiseField;
		private DataGridViewCheckBoxColumn Active;
		private DataGridViewTextBoxColumn Width;
		private DataGridViewComboBoxColumn Noise;
		private DataGridViewComboBoxColumn Extension;
		private DataGridViewTextBoxColumn Suffix;
		private ComboBox language;
	}
}