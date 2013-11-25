namespace ChooseAndCopy
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_BOP = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.open_bop_config_folder_cbx = new System.Windows.Forms.CheckBox();
            this.copy_bop_config_btn = new System.Windows.Forms.Button();
            this.includesAll_btn = new System.Windows.Forms.RadioButton();
            this.deselectBtn = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.onlySelected_btn = new System.Windows.Forms.RadioButton();
            this.TargetFolder_Bin_btn = new System.Windows.Forms.Button();
            this.excludeSelected_btn = new System.Windows.Forms.RadioButton();
            this.selectBtn = new System.Windows.Forms.Button();
            this.bop_config_target_folder_label = new System.Windows.Forms.Label();
            this.SourceFolder_Bin_btn = new System.Windows.Forms.Button();
            this.sourceBinFolder_lable = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.tabPage_etc = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filter_out_sys_altsys_files_ckb = new System.Windows.Forms.CheckBox();
            this.open_etc_folder_cbx = new System.Windows.Forms.CheckBox();
            this.copy_etc_btn = new System.Windows.Forms.Button();
            this.includesAll_btn_b = new System.Windows.Forms.RadioButton();
            this.deselectBtn_b = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onlySelected_btn_b = new System.Windows.Forms.RadioButton();
            this.TargetFolder_etc_btn = new System.Windows.Forms.Button();
            this.excludeSelected_btn_b = new System.Windows.Forms.RadioButton();
            this.selectBtn_b = new System.Windows.Forms.Button();
            this.etc_target_folder_label = new System.Windows.Forms.Label();
            this.SourceFolder_etc_btn = new System.Windows.Forms.Button();
            this.sourceEtcFolder_lable = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.sysinitFileFath = new System.Windows.Forms.Label();
            this.altsysinitFilePath = new System.Windows.Forms.Label();
            this.sysinitFilePath_TZ_btn = new System.Windows.Forms.Button();
            this.altsysinitFilePath_TZ_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BOP_sysinitFileName = new System.Windows.Forms.Label();
            this.TargetFileBtn = new System.Windows.Forms.Button();
            this.SourceFileBtn = new System.Windows.Forms.Button();
            this.ReplaceInfoBtn = new System.Windows.Forms.Button();
            this.SourceFileName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFilesCHKBOX = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_BOP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_etc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_BOP);
            this.tabControl1.Controls.Add(this.tabPage_etc);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_BOP
            // 
            this.tabPage_BOP.Controls.Add(this.groupBox1);
            this.tabPage_BOP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BOP.Name = "tabPage_BOP";
            this.tabPage_BOP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BOP.Size = new System.Drawing.Size(921, 395);
            this.tabPage_BOP.TabIndex = 0;
            this.tabPage_BOP.Text = "Copy Folder /bop_config";
            this.tabPage_BOP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy source files under /bin (or /bop_config) to target folder /bin/bop_config";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 291);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(220, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Apply the same procedure to other nodes";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_bop_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 308);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox_bop_SelectedValueChanged);
            this.comboBox2.DropDown += new System.EventHandler(this.comboBox_bop_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Amount of nodes in total";
            // 
            // open_bop_config_folder_cbx
            // 
            this.open_bop_config_folder_cbx.AutoSize = true;
            this.open_bop_config_folder_cbx.Checked = true;
            this.open_bop_config_folder_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.open_bop_config_folder_cbx.Location = new System.Drawing.Point(438, 291);
            this.open_bop_config_folder_cbx.Name = "open_bop_config_folder_cbx";
            this.open_bop_config_folder_cbx.Size = new System.Drawing.Size(161, 17);
            this.open_bop_config_folder_cbx.TabIndex = 20;
            this.open_bop_config_folder_cbx.Text = "Open target folder after copy";
            this.open_bop_config_folder_cbx.UseVisualStyleBackColor = true;
            // 
            // copy_bop_config_btn
            // 
            this.copy_bop_config_btn.Location = new System.Drawing.Point(12, 341);
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
            this.includesAll_btn.Location = new System.Drawing.Point(12, 213);
            this.includesAll_btn.Name = "includesAll_btn";
            this.includesAll_btn.Size = new System.Drawing.Size(222, 17);
            this.includesAll_btn.TabIndex = 18;
            this.includesAll_btn.Text = "Include all subfolders/files in source folder";
            this.includesAll_btn.UseVisualStyleBackColor = true;
            this.includesAll_btn.CheckedChanged += new System.EventHandler(this.includesAll_btn_CheckedChanged);
            // 
            // deselectBtn
            // 
            this.deselectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deselectBtn.BackgroundImage")));
            this.deselectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deselectBtn.Location = new System.Drawing.Point(438, 154);
            this.deselectBtn.Name = "deselectBtn";
            this.deselectBtn.Size = new System.Drawing.Size(33, 33);
            this.deselectBtn.TabIndex = 17;
            this.deselectBtn.Text = ".";
            this.deselectBtn.UseVisualStyleBackColor = true;
            this.deselectBtn.Click += new System.EventHandler(this.deselectBtn_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(13, 66);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb1.Size = new System.Drawing.Size(420, 147);
            this.lb1.TabIndex = 5;
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
            // onlySelected_btn
            // 
            this.onlySelected_btn.AutoSize = true;
            this.onlySelected_btn.Location = new System.Drawing.Point(477, 234);
            this.onlySelected_btn.Name = "onlySelected_btn";
            this.onlySelected_btn.Size = new System.Drawing.Size(305, 17);
            this.onlySelected_btn.TabIndex = 10;
            this.onlySelected_btn.Text = "Only include selected subfolders/files from the source folder";
            this.onlySelected_btn.UseVisualStyleBackColor = true;
            // 
            // TargetFolder_Bin_btn
            // 
            this.TargetFolder_Bin_btn.Location = new System.Drawing.Point(12, 262);
            this.TargetFolder_Bin_btn.Name = "TargetFolder_Bin_btn";
            this.TargetFolder_Bin_btn.Size = new System.Drawing.Size(123, 23);
            this.TargetFolder_Bin_btn.TabIndex = 2;
            this.TargetFolder_Bin_btn.Text = "Choose target folder";
            this.TargetFolder_Bin_btn.UseVisualStyleBackColor = true;
            this.TargetFolder_Bin_btn.Click += new System.EventHandler(this.TargetFolder_Bin_btn_Click);
            // 
            // excludeSelected_btn
            // 
            this.excludeSelected_btn.AutoSize = true;
            this.excludeSelected_btn.Checked = true;
            this.excludeSelected_btn.Location = new System.Drawing.Point(477, 213);
            this.excludeSelected_btn.Name = "excludeSelected_btn";
            this.excludeSelected_btn.Size = new System.Drawing.Size(285, 17);
            this.excludeSelected_btn.TabIndex = 9;
            this.excludeSelected_btn.TabStop = true;
            this.excludeSelected_btn.Text = "Exclude selected subfolders/files from the source folder";
            this.excludeSelected_btn.UseVisualStyleBackColor = true;
            // 
            // selectBtn
            // 
            this.selectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectBtn.BackgroundImage")));
            this.selectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectBtn.Location = new System.Drawing.Point(438, 91);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(33, 33);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.TabStop = false;
            this.selectBtn.Text = ".";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // bop_config_target_folder_label
            // 
            this.bop_config_target_folder_label.AutoSize = true;
            this.bop_config_target_folder_label.Location = new System.Drawing.Point(135, 266);
            this.bop_config_target_folder_label.Name = "bop_config_target_folder_label";
            this.bop_config_target_folder_label.Size = new System.Drawing.Size(16, 13);
            this.bop_config_target_folder_label.TabIndex = 14;
            this.bop_config_target_folder_label.Text = "...";
            // 
            // SourceFolder_Bin_btn
            // 
            this.SourceFolder_Bin_btn.Location = new System.Drawing.Point(14, 25);
            this.SourceFolder_Bin_btn.Name = "SourceFolder_Bin_btn";
            this.SourceFolder_Bin_btn.Size = new System.Drawing.Size(123, 23);
            this.SourceFolder_Bin_btn.TabIndex = 0;
            this.SourceFolder_Bin_btn.Text = "Choose source folder";
            this.SourceFolder_Bin_btn.UseVisualStyleBackColor = true;
            this.SourceFolder_Bin_btn.Click += new System.EventHandler(this.SourceFolder_Bin_btn_Click);
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
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(477, 66);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb2.Size = new System.Drawing.Size(420, 147);
            this.lb2.TabIndex = 6;
            // 
            // tabPage_etc
            // 
            this.tabPage_etc.Controls.Add(this.groupBox2);
            this.tabPage_etc.Location = new System.Drawing.Point(4, 22);
            this.tabPage_etc.Name = "tabPage_etc";
            this.tabPage_etc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_etc.Size = new System.Drawing.Size(921, 395);
            this.tabPage_etc.TabIndex = 1;
            this.tabPage_etc.Text = "Copy Folder /etc";
            this.tabPage_etc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.filter_out_sys_altsys_files_ckb);
            this.groupBox2.Controls.Add(this.open_etc_folder_cbx);
            this.groupBox2.Controls.Add(this.copy_etc_btn);
            this.groupBox2.Controls.Add(this.includesAll_btn_b);
            this.groupBox2.Controls.Add(this.deselectBtn_b);
            this.groupBox2.Controls.Add(this.lb3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.onlySelected_btn_b);
            this.groupBox2.Controls.Add(this.TargetFolder_etc_btn);
            this.groupBox2.Controls.Add(this.excludeSelected_btn_b);
            this.groupBox2.Controls.Add(this.selectBtn_b);
            this.groupBox2.Controls.Add(this.etc_target_folder_label);
            this.groupBox2.Controls.Add(this.SourceFolder_etc_btn);
            this.groupBox2.Controls.Add(this.sourceEtcFolder_lable);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 378);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copy source files under /etc to target folder /etc";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 291);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(220, 17);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Apply the same procedure to other nodes";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_etc_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(158, 308);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(43, 21);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox_etc_SelectedValueChanged);
            this.comboBox3.DropDown += new System.EventHandler(this.comboBox_etc_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Amount of nodes in total";
            // 
            // filter_out_sys_altsys_files_ckb
            // 
            this.filter_out_sys_altsys_files_ckb.AutoSize = true;
            this.filter_out_sys_altsys_files_ckb.Checked = true;
            this.filter_out_sys_altsys_files_ckb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filter_out_sys_altsys_files_ckb.Location = new System.Drawing.Point(438, 291);
            this.filter_out_sys_altsys_files_ckb.Name = "filter_out_sys_altsys_files_ckb";
            this.filter_out_sys_altsys_files_ckb.Size = new System.Drawing.Size(262, 17);
            this.filter_out_sys_altsys_files_ckb.TabIndex = 21;
            this.filter_out_sys_altsys_files_ckb.Text = "filter out files for file name starting with sys or altsys";
            this.filter_out_sys_altsys_files_ckb.UseVisualStyleBackColor = true;
            // 
            // open_etc_folder_cbx
            // 
            this.open_etc_folder_cbx.AutoSize = true;
            this.open_etc_folder_cbx.Checked = true;
            this.open_etc_folder_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.open_etc_folder_cbx.Location = new System.Drawing.Point(438, 312);
            this.open_etc_folder_cbx.Name = "open_etc_folder_cbx";
            this.open_etc_folder_cbx.Size = new System.Drawing.Size(161, 17);
            this.open_etc_folder_cbx.TabIndex = 20;
            this.open_etc_folder_cbx.Text = "Open target folder after copy";
            this.open_etc_folder_cbx.UseVisualStyleBackColor = true;
            // 
            // copy_etc_btn
            // 
            this.copy_etc_btn.Location = new System.Drawing.Point(12, 341);
            this.copy_etc_btn.Name = "copy_etc_btn";
            this.copy_etc_btn.Size = new System.Drawing.Size(58, 23);
            this.copy_etc_btn.TabIndex = 19;
            this.copy_etc_btn.Text = "Copy";
            this.copy_etc_btn.UseVisualStyleBackColor = true;
            this.copy_etc_btn.Click += new System.EventHandler(this.copy_etc_btn_Click);
            // 
            // includesAll_btn_b
            // 
            this.includesAll_btn_b.AutoSize = true;
            this.includesAll_btn_b.Location = new System.Drawing.Point(12, 213);
            this.includesAll_btn_b.Name = "includesAll_btn_b";
            this.includesAll_btn_b.Size = new System.Drawing.Size(222, 17);
            this.includesAll_btn_b.TabIndex = 18;
            this.includesAll_btn_b.Text = "Include all subfolders/files in source folder";
            this.includesAll_btn_b.UseVisualStyleBackColor = true;
            this.includesAll_btn_b.CheckedChanged += new System.EventHandler(this.includesAll_btn_CheckedChanged_b);
            // 
            // deselectBtn_b
            // 
            this.deselectBtn_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deselectBtn_b.BackgroundImage")));
            this.deselectBtn_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deselectBtn_b.Location = new System.Drawing.Point(438, 154);
            this.deselectBtn_b.Name = "deselectBtn_b";
            this.deselectBtn_b.Size = new System.Drawing.Size(33, 33);
            this.deselectBtn_b.TabIndex = 17;
            this.deselectBtn_b.Text = ".";
            this.deselectBtn_b.UseVisualStyleBackColor = true;
            this.deselectBtn_b.Click += new System.EventHandler(this.deselectBtn_b_Click);
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.Location = new System.Drawing.Point(13, 66);
            this.lb3.Name = "lb3";
            this.lb3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb3.Size = new System.Drawing.Size(420, 147);
            this.lb3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selected subfolders/files:";
            // 
            // onlySelected_btn_b
            // 
            this.onlySelected_btn_b.AutoSize = true;
            this.onlySelected_btn_b.Location = new System.Drawing.Point(477, 234);
            this.onlySelected_btn_b.Name = "onlySelected_btn_b";
            this.onlySelected_btn_b.Size = new System.Drawing.Size(305, 17);
            this.onlySelected_btn_b.TabIndex = 10;
            this.onlySelected_btn_b.Text = "Only include selected subfolders/files from the source folder";
            this.onlySelected_btn_b.UseVisualStyleBackColor = true;
            // 
            // TargetFolder_etc_btn
            // 
            this.TargetFolder_etc_btn.Location = new System.Drawing.Point(12, 262);
            this.TargetFolder_etc_btn.Name = "TargetFolder_etc_btn";
            this.TargetFolder_etc_btn.Size = new System.Drawing.Size(123, 23);
            this.TargetFolder_etc_btn.TabIndex = 2;
            this.TargetFolder_etc_btn.Text = "Choose target folder";
            this.TargetFolder_etc_btn.UseVisualStyleBackColor = true;
            this.TargetFolder_etc_btn.Click += new System.EventHandler(this.TargetFolder_etc_btn_Click);
            // 
            // excludeSelected_btn_b
            // 
            this.excludeSelected_btn_b.AutoSize = true;
            this.excludeSelected_btn_b.Checked = true;
            this.excludeSelected_btn_b.Location = new System.Drawing.Point(477, 213);
            this.excludeSelected_btn_b.Name = "excludeSelected_btn_b";
            this.excludeSelected_btn_b.Size = new System.Drawing.Size(285, 17);
            this.excludeSelected_btn_b.TabIndex = 9;
            this.excludeSelected_btn_b.TabStop = true;
            this.excludeSelected_btn_b.Text = "Exclude selected subfolders/files from the source folder";
            this.excludeSelected_btn_b.UseVisualStyleBackColor = true;
            // 
            // selectBtn_b
            // 
            this.selectBtn_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectBtn_b.BackgroundImage")));
            this.selectBtn_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectBtn_b.Location = new System.Drawing.Point(438, 91);
            this.selectBtn_b.Name = "selectBtn_b";
            this.selectBtn_b.Size = new System.Drawing.Size(33, 33);
            this.selectBtn_b.TabIndex = 16;
            this.selectBtn_b.TabStop = false;
            this.selectBtn_b.Text = ".";
            this.selectBtn_b.UseVisualStyleBackColor = true;
            this.selectBtn_b.Click += new System.EventHandler(this.selectBtn_b_Click);
            // 
            // etc_target_folder_label
            // 
            this.etc_target_folder_label.AutoSize = true;
            this.etc_target_folder_label.Location = new System.Drawing.Point(134, 266);
            this.etc_target_folder_label.Name = "etc_target_folder_label";
            this.etc_target_folder_label.Size = new System.Drawing.Size(16, 13);
            this.etc_target_folder_label.TabIndex = 14;
            this.etc_target_folder_label.Text = "...";
            // 
            // SourceFolder_etc_btn
            // 
            this.SourceFolder_etc_btn.Location = new System.Drawing.Point(14, 25);
            this.SourceFolder_etc_btn.Name = "SourceFolder_etc_btn";
            this.SourceFolder_etc_btn.Size = new System.Drawing.Size(123, 23);
            this.SourceFolder_etc_btn.TabIndex = 0;
            this.SourceFolder_etc_btn.Text = "Choose source folder";
            this.SourceFolder_etc_btn.UseVisualStyleBackColor = true;
            this.SourceFolder_etc_btn.Click += new System.EventHandler(this.SourceFolder_etc_btn_Click);
            // 
            // sourceEtcFolder_lable
            // 
            this.sourceEtcFolder_lable.AutoSize = true;
            this.sourceEtcFolder_lable.Location = new System.Drawing.Point(135, 30);
            this.sourceEtcFolder_lable.Name = "sourceEtcFolder_lable";
            this.sourceEtcFolder_lable.Size = new System.Drawing.Size(16, 13);
            this.sourceEtcFolder_lable.TabIndex = 12;
            this.sourceEtcFolder_lable.Text = "...";
            // 
            // lb4
            // 
            this.lb4.FormattingEnabled = true;
            this.lb4.Location = new System.Drawing.Point(477, 66);
            this.lb4.Name = "lb4";
            this.lb4.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb4.Size = new System.Drawing.Size(420, 147);
            this.lb4.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.sysinitFileFath);
            this.tabPage3.Controls.Add(this.altsysinitFilePath);
            this.tabPage3.Controls.Add(this.sysinitFilePath_TZ_btn);
            this.tabPage3.Controls.Add(this.altsysinitFilePath_TZ_btn);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.BOP_sysinitFileName);
            this.tabPage3.Controls.Add(this.TargetFileBtn);
            this.tabPage3.Controls.Add(this.SourceFileBtn);
            this.tabPage3.Controls.Add(this.ReplaceInfoBtn);
            this.tabPage3.Controls.Add(this.SourceFileName);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Replacement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(667, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 319);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "USEFUL RESOURCES";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(105, 74);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(131, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "winmerge.org/downloads/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "If you would like to compare files and/or folders,\nWinMerge is strongly recommend" +
                "ed, which can\nbe downloaded from";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(69, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "notepad-plus-plus.org/download/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Notepad++ : ";
            // 
            // sysinitFileFath
            // 
            this.sysinitFileFath.AutoSize = true;
            this.sysinitFileFath.Location = new System.Drawing.Point(23, 211);
            this.sysinitFileFath.Name = "sysinitFileFath";
            this.sysinitFileFath.Size = new System.Drawing.Size(307, 13);
            this.sysinitFileFath.TabIndex = 29;
            this.sysinitFileFath.Text = "Press button below to choose sysinit file for updating Time Zone";
            // 
            // altsysinitFilePath
            // 
            this.altsysinitFilePath.AutoSize = true;
            this.altsysinitFilePath.Location = new System.Drawing.Point(23, 161);
            this.altsysinitFilePath.Name = "altsysinitFilePath";
            this.altsysinitFilePath.Size = new System.Drawing.Size(318, 13);
            this.altsysinitFilePath.TabIndex = 28;
            this.altsysinitFilePath.Text = "Press button below to choose altsysinit file for updating Time Zone";
            // 
            // sysinitFilePath_TZ_btn
            // 
            this.sysinitFilePath_TZ_btn.Location = new System.Drawing.Point(23, 226);
            this.sysinitFilePath_TZ_btn.Name = "sysinitFilePath_TZ_btn";
            this.sysinitFilePath_TZ_btn.Size = new System.Drawing.Size(98, 23);
            this.sysinitFilePath_TZ_btn.TabIndex = 27;
            this.sysinitFilePath_TZ_btn.Text = "Choose sysinit";
            this.sysinitFilePath_TZ_btn.UseVisualStyleBackColor = true;
            this.sysinitFilePath_TZ_btn.Click += new System.EventHandler(this.sysinitFilePath_TZ_btn_Click);
            // 
            // altsysinitFilePath_TZ_btn
            // 
            this.altsysinitFilePath_TZ_btn.Location = new System.Drawing.Point(23, 175);
            this.altsysinitFilePath_TZ_btn.Name = "altsysinitFilePath_TZ_btn";
            this.altsysinitFilePath_TZ_btn.Size = new System.Drawing.Size(98, 23);
            this.altsysinitFilePath_TZ_btn.TabIndex = 26;
            this.altsysinitFilePath_TZ_btn.Text = "Choose altsysinit";
            this.altsysinitFilePath_TZ_btn.UseVisualStyleBackColor = true;
            this.altsysinitFilePath_TZ_btn.Click += new System.EventHandler(this.altsysinitFilePath_TZ_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Press button below to replace fields of target file with ones in source file";
            // 
            // BOP_sysinitFileName
            // 
            this.BOP_sysinitFileName.AutoSize = true;
            this.BOP_sysinitFileName.Location = new System.Drawing.Point(23, 113);
            this.BOP_sysinitFileName.Name = "BOP_sysinitFileName";
            this.BOP_sysinitFileName.Size = new System.Drawing.Size(284, 13);
            this.BOP_sysinitFileName.TabIndex = 21;
            this.BOP_sysinitFileName.Text = "Press button below to choose BOP_sysinit file in folder /bin";
            // 
            // TargetFileBtn
            // 
            this.TargetFileBtn.Location = new System.Drawing.Point(23, 127);
            this.TargetFileBtn.Name = "TargetFileBtn";
            this.TargetFileBtn.Size = new System.Drawing.Size(151, 23);
            this.TargetFileBtn.TabIndex = 20;
            this.TargetFileBtn.Text = "Choose Target BOP_sysinit";
            this.TargetFileBtn.UseVisualStyleBackColor = true;
            this.TargetFileBtn.Click += new System.EventHandler(this.TargetFileBtn_Click);
            // 
            // SourceFileBtn
            // 
            this.SourceFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceFileBtn.Location = new System.Drawing.Point(23, 44);
            this.SourceFileBtn.Name = "SourceFileBtn";
            this.SourceFileBtn.Size = new System.Drawing.Size(151, 23);
            this.SourceFileBtn.TabIndex = 19;
            this.SourceFileBtn.Text = "Choose Source Sysinit File";
            this.SourceFileBtn.UseVisualStyleBackColor = true;
            this.SourceFileBtn.Click += new System.EventHandler(this.SourceFileBtn_Click);
            // 
            // ReplaceInfoBtn
            // 
            this.ReplaceInfoBtn.Location = new System.Drawing.Point(23, 357);
            this.ReplaceInfoBtn.Name = "ReplaceInfoBtn";
            this.ReplaceInfoBtn.Size = new System.Drawing.Size(62, 23);
            this.ReplaceInfoBtn.TabIndex = 18;
            this.ReplaceInfoBtn.Text = "Replace";
            this.ReplaceInfoBtn.UseVisualStyleBackColor = true;
            this.ReplaceInfoBtn.Click += new System.EventHandler(this.ReplaceInfoBtn_Click);
            // 
            // SourceFileName
            // 
            this.SourceFileName.AutoSize = true;
            this.SourceFileName.Location = new System.Drawing.Point(23, 29);
            this.SourceFileName.Name = "SourceFileName";
            this.SourceFileName.Size = new System.Drawing.Size(292, 13);
            this.SourceFileName.TabIndex = 17;
            this.SourceFileName.Text = "Press button below to choose source sysinit file in folder /etc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openFilesCHKBOX);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 240);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TARGET";
            // 
            // openFilesCHKBOX
            // 
            this.openFilesCHKBOX.AutoSize = true;
            this.openFilesCHKBOX.Location = new System.Drawing.Point(442, 183);
            this.openFilesCHKBOX.Name = "openFilesCHKBOX";
            this.openFilesCHKBOX.Size = new System.Drawing.Size(194, 17);
            this.openFilesCHKBOX.TabIndex = 30;
            this.openFilesCHKBOX.Text = "Open updated files with NotePad++";
            this.openFilesCHKBOX.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(220, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Apply the same procedure to other nodes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Amount of nodes in total";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 77);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SOURCE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 426);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EasyClick";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_BOP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_etc.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_BOP;
        private System.Windows.Forms.TabPage tabPage_etc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox open_bop_config_folder_cbx;
        private System.Windows.Forms.Button copy_bop_config_btn;
        private System.Windows.Forms.RadioButton includesAll_btn;
        private System.Windows.Forms.Button deselectBtn;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton onlySelected_btn;
        private System.Windows.Forms.Button TargetFolder_Bin_btn;
        private System.Windows.Forms.RadioButton excludeSelected_btn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label bop_config_target_folder_label;
        private System.Windows.Forms.Button SourceFolder_Bin_btn;
        private System.Windows.Forms.Label sourceBinFolder_lable;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox open_etc_folder_cbx;
        private System.Windows.Forms.Button copy_etc_btn;
        private System.Windows.Forms.RadioButton includesAll_btn_b;
        private System.Windows.Forms.Button deselectBtn_b;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton onlySelected_btn_b;
        private System.Windows.Forms.Button TargetFolder_etc_btn;
        private System.Windows.Forms.RadioButton excludeSelected_btn_b;
        private System.Windows.Forms.Button selectBtn_b;
        private System.Windows.Forms.Label etc_target_folder_label;
        private System.Windows.Forms.Button SourceFolder_etc_btn;
        private System.Windows.Forms.Label sourceEtcFolder_lable;
        private System.Windows.Forms.ListBox lb4;
        private System.Windows.Forms.CheckBox filter_out_sys_altsys_files_ckb;
        private System.Windows.Forms.CheckBox openFilesCHKBOX;
        private System.Windows.Forms.Label sysinitFileFath;
        private System.Windows.Forms.Label altsysinitFilePath;
        private System.Windows.Forms.Button sysinitFilePath_TZ_btn;
        private System.Windows.Forms.Button altsysinitFilePath_TZ_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label BOP_sysinitFileName;
        private System.Windows.Forms.Button TargetFileBtn;
        private System.Windows.Forms.Button SourceFileBtn;
        private System.Windows.Forms.Button ReplaceInfoBtn;
        private System.Windows.Forms.Label SourceFileName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

