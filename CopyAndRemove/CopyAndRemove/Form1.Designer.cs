namespace CopyAndRemove
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SourceFolder_Bin_btn = new System.Windows.Forms.Button();
            this.TargetFolder_Bin_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.excludeSelected_btn = new System.Windows.Forms.RadioButton();
            this.onlySelected_btn = new System.Windows.Forms.RadioButton();
            this.sourceBinFolder_lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bop_config_target_folder_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.deselectBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copy_bop_config_btn = new System.Windows.Forms.Button();
            this.includesAll_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.open_bop_config_folder_cbx = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceFolder_Bin_btn
            // 
            this.SourceFolder_Bin_btn.Location = new System.Drawing.Point(6, 25);
            this.SourceFolder_Bin_btn.Name = "SourceFolder_Bin_btn";
            this.SourceFolder_Bin_btn.Size = new System.Drawing.Size(123, 23);
            this.SourceFolder_Bin_btn.TabIndex = 0;
            this.SourceFolder_Bin_btn.Text = "Choose source folder";
            this.SourceFolder_Bin_btn.UseVisualStyleBackColor = true;
            this.SourceFolder_Bin_btn.Click += new System.EventHandler(this.SourceFolder_Bin_btn_Click);
            // 
            // TargetFolder_Bin_btn
            // 
            this.TargetFolder_Bin_btn.Location = new System.Drawing.Point(12, 219);
            this.TargetFolder_Bin_btn.Name = "TargetFolder_Bin_btn";
            this.TargetFolder_Bin_btn.Size = new System.Drawing.Size(123, 23);
            this.TargetFolder_Bin_btn.TabIndex = 2;
            this.TargetFolder_Bin_btn.Text = "Choose target folder";
            this.TargetFolder_Bin_btn.UseVisualStyleBackColor = true;
            this.TargetFolder_Bin_btn.Click += new System.EventHandler(this.TargetFolder_Bin_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(36, 458);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(278, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "filter out files with file name starting with sys and altsys";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copy source files under /etc to target folder /etc";
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(12, 66);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb1.Size = new System.Drawing.Size(420, 95);
            this.lb1.TabIndex = 5;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(477, 66);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb2.Size = new System.Drawing.Size(420, 95);
            this.lb2.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            // 
            // excludeSelected_btn
            // 
            this.excludeSelected_btn.AutoSize = true;
            this.excludeSelected_btn.Checked = true;
            this.excludeSelected_btn.Location = new System.Drawing.Point(477, 167);
            this.excludeSelected_btn.Name = "excludeSelected_btn";
            this.excludeSelected_btn.Size = new System.Drawing.Size(285, 17);
            this.excludeSelected_btn.TabIndex = 9;
            this.excludeSelected_btn.TabStop = true;
            this.excludeSelected_btn.Text = "Exclude selected subfolders/files from the source folder";
            this.excludeSelected_btn.UseVisualStyleBackColor = true;
            // 
            // onlySelected_btn
            // 
            this.onlySelected_btn.AutoSize = true;
            this.onlySelected_btn.Location = new System.Drawing.Point(477, 190);
            this.onlySelected_btn.Name = "onlySelected_btn";
            this.onlySelected_btn.Size = new System.Drawing.Size(305, 17);
            this.onlySelected_btn.TabIndex = 10;
            this.onlySelected_btn.Text = "Only include selected subfolders/files from the source folder";
            this.onlySelected_btn.UseVisualStyleBackColor = true;
            // 
            // sourceBinFolder_lable
            // 
            this.sourceBinFolder_lable.AutoSize = true;
            this.sourceBinFolder_lable.Location = new System.Drawing.Point(135, 30);
            this.sourceBinFolder_lable.Name = "sourceBinFolder_lable";
            this.sourceBinFolder_lable.Size = new System.Drawing.Size(16, 13);
            this.sourceBinFolder_lable.TabIndex = 12;
            this.sourceBinFolder_lable.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selected subfolders/files:";
            // 
            // bop_config_target_folder_label
            // 
            this.bop_config_target_folder_label.AutoSize = true;
            this.bop_config_target_folder_label.Location = new System.Drawing.Point(135, 224);
            this.bop_config_target_folder_label.Name = "bop_config_target_folder_label";
            this.bop_config_target_folder_label.Size = new System.Drawing.Size(16, 13);
            this.bop_config_target_folder_label.TabIndex = 14;
            this.bop_config_target_folder_label.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // selectBtn
            // 
            this.selectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectBtn.BackgroundImage")));
            this.selectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectBtn.Location = new System.Drawing.Point(438, 75);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(33, 33);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.TabStop = false;
            this.selectBtn.Text = ".";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // deselectBtn
            // 
            this.deselectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deselectBtn.BackgroundImage")));
            this.deselectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deselectBtn.Location = new System.Drawing.Point(438, 116);
            this.deselectBtn.Name = "deselectBtn";
            this.deselectBtn.Size = new System.Drawing.Size(33, 33);
            this.deselectBtn.TabIndex = 17;
            this.deselectBtn.Text = ".";
            this.deselectBtn.UseVisualStyleBackColor = true;
            this.deselectBtn.Click += new System.EventHandler(this.deselectBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_bop_config_folder_cbx);
            this.groupBox1.Controls.Add(this.copy_bop_config_btn);
            this.groupBox1.Controls.Add(this.includesAll_btn);
            this.groupBox1.Controls.Add(this.deselectBtn);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.onlySelected_btn);
            this.groupBox1.Controls.Add(this.TargetFolder_Bin_btn);
            this.groupBox1.Controls.Add(this.excludeSelected_btn);
            this.groupBox1.Controls.Add(this.selectBtn);
            this.groupBox1.Controls.Add(this.bop_config_target_folder_label);
            this.groupBox1.Controls.Add(this.SourceFolder_Bin_btn);
            this.groupBox1.Controls.Add(this.sourceBinFolder_lable);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy source files under /bin (or /bop_config) to target folder /bin/bop_config";
            // 
            // copy_bop_config_btn
            // 
            this.copy_bop_config_btn.Location = new System.Drawing.Point(12, 246);
            this.copy_bop_config_btn.Name = "copy_bop_config_btn";
            this.copy_bop_config_btn.Size = new System.Drawing.Size(58, 23);
            this.copy_bop_config_btn.TabIndex = 19;
            this.copy_bop_config_btn.Text = "Copy";
            this.copy_bop_config_btn.UseVisualStyleBackColor = true;
            this.copy_bop_config_btn.Click += new System.EventHandler(this.copy_bop_config_btn_Click);
            // 
            // includesAll_btn
            // 
            this.includesAll_btn.AutoSize = true;
            this.includesAll_btn.Location = new System.Drawing.Point(12, 167);
            this.includesAll_btn.Name = "includesAll_btn";
            this.includesAll_btn.Size = new System.Drawing.Size(222, 17);
            this.includesAll_btn.TabIndex = 18;
            this.includesAll_btn.Text = "Include all subfolders/files in source folder";
            this.includesAll_btn.UseVisualStyleBackColor = true;
            this.includesAll_btn.CheckedChanged += new System.EventHandler(this.includesAll_btn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subfolders/files in source folder: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // open_bop_config_folder_cbx
            // 
            this.open_bop_config_folder_cbx.AutoSize = true;
            this.open_bop_config_folder_cbx.Checked = true;
            this.open_bop_config_folder_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.open_bop_config_folder_cbx.Location = new System.Drawing.Point(74, 251);
            this.open_bop_config_folder_cbx.Name = "open_bop_config_folder_cbx";
            this.open_bop_config_folder_cbx.Size = new System.Drawing.Size(161, 17);
            this.open_bop_config_folder_cbx.TabIndex = 20;
            this.open_bop_config_folder_cbx.Text = "Open target folder after copy";
            this.open_bop_config_folder_cbx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 497);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Folder/Files Rearranger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SourceFolder_Bin_btn;
        private System.Windows.Forms.Button TargetFolder_Bin_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton excludeSelected_btn;
        private System.Windows.Forms.RadioButton onlySelected_btn;
        private System.Windows.Forms.Label sourceBinFolder_lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bop_config_target_folder_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button deselectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton includesAll_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button copy_bop_config_btn;
        private System.Windows.Forms.CheckBox open_bop_config_folder_cbx;
    }
}

