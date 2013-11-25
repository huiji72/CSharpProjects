using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ChooseAndCopy
{
    public partial class Form1 : Form
    {
        Assembly _assembly;
        Stream _nppStream;
        StreamReader _StreamReader;

        public Form1()
        {
            InitializeComponent();
        }

        //private void SourceFolder_Bin_btn_Click(object sender, EventArgs e)
        //{

        //}

        //private void TargetFolder_Bin_btn_Click(object sender, EventArgs e)
        //{

        //}

        //private void copy_bop_config_btn_Click(object sender, EventArgs e)
        //{

        //}
        private void SourceFolder_Bin_btn_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog openSourceFolder = new OpenFileDialog();
            openSourceFolder.ShowReadOnly = true;

            openSourceFolder.ShowDialog();

            this.sourceBinFolder_lable.Text = openSourceFolder.FileName;*/

            FolderBrowserDialog binSourceFolder = new FolderBrowserDialog();
            binSourceFolder.ShowNewFolderButton = false;
            binSourceFolder.ShowDialog();
            
            this.sourceBinFolder_lable.Text = binSourceFolder.SelectedPath;

            ArrayList al = new ArrayList();
            al = RearrangerHelper.GetFoldersAndFilesInSourceBinFolder(this.sourceBinFolder_lable.Text);
            LoadAvailableItems(al, tabPage_BOP);

           
        }
        private void LoadAvailableItems(ArrayList al, TabPage tp)
        {
            try
            {
                if (tp == this.tabPage_BOP)
                    this.lb1.Items.Clear();
                else if (tp == this.tabPage_etc)
                    this.lb3.Items.Clear();


                foreach (object o in al)
                {
                    FolderFile f = (FolderFile)o;
                    string filename = f.name;
                    filename = truncateItemName(filename, tp);
                    //string filetype = f.ft.ToString();

                    //RearrangerHelper rah = new RearrangerHelper();

                    if (f.ft == fileType.folder)
                        filename = RearrangerHelper.folderLabel + filename;

                    
                    if (tp == this.tabPage_BOP)
                        lb1.Items.Add(filename);
                    else if (tp == this.tabPage_etc)
                        lb3.Items.Add(filename);

                }
            }
            catch (Exception ex)
            {
                //string str = "Exception detected when populating the available files list";
                throw new Exception(ex.ToString());
            }

        }

        private string truncateItemName(string name, TabPage tp)
        {
            int length = 0;
            if (tp == this.tabPage_BOP)
                length = this.sourceBinFolder_lable.Text.Length;
            else if (tp == this.tabPage_etc)
                length = this.sourceEtcFolder_lable.Text.Length;

            return name.Substring(length + 1);
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string item;
            for (int i = 0; i < lb1.Items.Count; i ++ )
            {
                item = lb1.Items[i].ToString();
                if (this.lb1.SelectedIndex >= 0)
                {
                    lb2.Items.Add(this.lb1.Items[this.lb1.SelectedIndex]);
                    this.lb1.Items.RemoveAt(this.lb1.SelectedIndex);
                    i--;
                    
                }
            }
        }

        private void deselectBtn_Click(object sender, EventArgs e)
        {
            string item;
            for (int i = 0; i < lb2.Items.Count; i++)
            {
                item = lb2.Items[i].ToString();
                if (this.lb2.SelectedIndex >= 0)
                {
                    lb1.Items.Add(this.lb2.Items[this.lb2.SelectedIndex]);//this.lb2.Items[this.lb2.SelectedIndex]
                    lb1.Refresh();
                    this.lb2.Items.RemoveAt(this.lb2.SelectedIndex);
                }
            }
        }

        private void TargetFolder_Bin_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog binSourceFolder = new FolderBrowserDialog();
            binSourceFolder.ShowNewFolderButton = false;
            binSourceFolder.ShowDialog();
            
            //this.sourceBinFolder_lable.Text = binSourceFolder.SelectedPath;
            if (binSourceFolder.SelectedPath.Contains("bin\\bop_config"))
                this.bop_config_target_folder_label.Text = binSourceFolder.SelectedPath;
            else
            {
                //this.bop_config_target_folder_label.Text = "Please choose target folder \"bin\\bop_config\"!";
                this.bop_config_target_folder_label.Text = "";
                MessageBox.Show("Please choose target folder \"bin\\bop_config\"!", "REMINDER",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copy_bop_config_btn_Click(object sender, EventArgs e)
        {
            if (this.bop_config_target_folder_label.Text != "")
            {
                string targetPath = this.bop_config_target_folder_label.Text;
                string sourcePath = this.sourceBinFolder_lable.Text;
                
                bool isBatchMode = false;

                if (_selectedIndex_bop >= 1) //for batch
                {
                    isBatchMode = true;
                    if (this.includesAll_btn.Checked == true || this.excludeSelected_btn.Checked == true)
                    {
                        ArrayList al_target_all_selected_nodes = new ArrayList();
                        ArrayList al_source_all_selected_nodes = new ArrayList();
                        ArrayList al_excluded_folders = new ArrayList();
                        bool reselectNeeded = false; //if reselected = true, means files have been excluded, which is not expected. 
                        //Then reselecting subfolders/files or changing option is needed.

                        bool isSource = false;
                        al_target_all_selected_nodes = ChooseAndCopy.RearrangerHelper.GetSourceOrTargetFoldersForSelectedNodes(targetPath, _selectedIndex_bop, isSource);

                        isSource = true;
                        al_source_all_selected_nodes = ChooseAndCopy.RearrangerHelper.GetSourceOrTargetFoldersForSelectedNodes(sourcePath, _selectedIndex_bop, isSource);

                        if (this.excludeSelected_btn.Checked == true)
                        {
                            for (int i = 0; i < lb2.Items.Count; i++)
                            {
                                if (lb2.Items[i].ToString().ToLower().Contains("folder : "))
                                    al_excluded_folders.Add(lb2.Items[i].ToString().Remove(0, ChooseAndCopy.RearrangerHelper.folderLabel.Length));
                                else
                                {
                                    //write error log here -- only folders should be selected for batch mode
                                    MessageBox.Show("Only folders can be excluded when using Batch Mode!", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    reselectNeeded = true;
                                }
                            }
                        }
                        if (!reselectNeeded)
                        {
                            if (al_source_all_selected_nodes.Count == al_target_all_selected_nodes.Count)
                            {
                                string _sourcePath;
                                string _targetPath;

                                for (int i = 0; i < al_source_all_selected_nodes.Count; i++)
                                {
                                    _sourcePath = al_source_all_selected_nodes[i].ToString();
                                    _targetPath = al_target_all_selected_nodes[i].ToString();

                                    RearrangerHelper.Copy_BOP_ETC_Files(_sourcePath, _targetPath, al_excluded_folders, tabPage_etc, this.filter_out_sys_altsys_files_ckb.Checked, isBatchMode);
                                }


                                foreach (string _target_path_to_open in al_target_all_selected_nodes)
                                {
                                    if (this.open_etc_folder_cbx.Checked)
                                    {
                                        openFolder(_target_path_to_open);
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("\"Only include selected subfolders/files from the source folder\" does NOT support Batch Mode!", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else //for just one at one time
                {
                    isBatchMode = false;
                    ArrayList al_source = new ArrayList();
                    if (this.includesAll_btn.Checked == true || this.excludeSelected_btn.Checked == true)
                    {
                        for (int i = 0; i < lb1.Items.Count; i++)
                        {
                            al_source.Add(lb1.Items[i].ToString());
                        }
                    }
                    else if (this.onlySelected_btn.Checked == true)
                    {
                        for (int i = 0; i < lb2.Items.Count; i++)
                        {
                            al_source.Add(lb2.Items[i].ToString());
                        }
                    }

                    RearrangerHelper.Copy_BOP_ETC_Files(sourcePath, targetPath, al_source, tabPage_BOP, false, isBatchMode);

                    if (this.open_bop_config_folder_cbx.Checked)
                    {
                        string myPath = targetPath;
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = myPath;
                        prc.Start();
                    }
                }
            }
        }

        private void includesAll_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.includesAll_btn.Checked == true)
            {
                ArrayList al = new ArrayList();
                al = RearrangerHelper.GetFoldersAndFilesInSourceBinFolder(this.sourceBinFolder_lable.Text);
                LoadAvailableItems(al, tabPage_BOP);

                this.lb2.Items.Clear();
            }
            
        }

        private void selectBtn_b_Click(object sender, EventArgs e)
        {
            string item;
            for (int i = 0; i < lb3.Items.Count; i++)
            {
                item = lb3.Items[i].ToString();
                if (this.lb3.SelectedIndex >= 0)
                {
                    lb4.Items.Add(this.lb3.Items[this.lb3.SelectedIndex]);
                    this.lb3.Items.RemoveAt(this.lb3.SelectedIndex);
                    i--;

                }
            }
        }

        private void deselectBtn_b_Click(object sender, EventArgs e)
        {
            string item;
            ArrayList al= new ArrayList();
            for (int i = 0; i < lb4.Items.Count; i++)
            {
                item = lb4.Items[i].ToString();
                if (this.lb4.SelectedIndex >= 0)
                {
                    //lb3.Items.Add(this.lb4.Items[this.lb4.SelectedIndex]);
                    al.Add(this.lb4.Items[this.lb4.SelectedIndex]);
                    lb3.Items.Add(al[0]);
                    lb3.Refresh();
                    this.lb4.Items.RemoveAt(this.lb4.SelectedIndex);
                }
            }
        }

        private void includesAll_btn_CheckedChanged_b(object sender, EventArgs e)
        {
            if (this.includesAll_btn_b.Checked == true)
            {
                ArrayList al = new ArrayList();
                al = RearrangerHelper.GetFoldersAndFilesInSourceBinFolder(this.sourceEtcFolder_lable.Text);
                LoadAvailableItems(al, tabPage_etc);

                this.lb4.Items.Clear();
            }
        }

        private void SourceFolder_etc_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog binSourceFolder = new FolderBrowserDialog();
            binSourceFolder.ShowNewFolderButton = false;
            binSourceFolder.ShowDialog();

            this.sourceEtcFolder_lable.Text = binSourceFolder.SelectedPath;

            ArrayList al = new ArrayList();
            al = RearrangerHelper.GetFoldersAndFilesInSourceBinFolder(this.sourceEtcFolder_lable.Text);
            LoadAvailableItems(al, tabPage_etc);
        }

        private void TargetFolder_etc_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog binSourceFolder = new FolderBrowserDialog();
            binSourceFolder.ShowNewFolderButton = false;
            binSourceFolder.ShowDialog();

            this.etc_target_folder_label.Text = binSourceFolder.SelectedPath;
        }

        private void copy_etc_btn_Click(object sender, EventArgs e)
        {
            string targetPath = this.etc_target_folder_label.Text;
            string sourcePath = this.sourceEtcFolder_lable.Text;

            bool isBatchMode;


            if (_selectedIndex_etc >= 1) //for batch
            {
                isBatchMode = true;
                if (this.includesAll_btn_b.Checked == true || this.excludeSelected_btn_b.Checked == true)
                {
                    ArrayList al_target_all_selected_nodes = new ArrayList();
                    ArrayList al_source_all_selected_nodes = new ArrayList();
                    ArrayList al_excluded_folders = new ArrayList();
                    bool reselectNeeded = false; //if reselected = true, means files have been excluded, which is not expected. 
                                                 //Then reselecting subfolders/files or changing option is needed.

                    bool isSource = false;
                    al_target_all_selected_nodes = ChooseAndCopy.RearrangerHelper.GetSourceOrTargetFoldersForSelectedNodes(targetPath, _selectedIndex_etc, isSource);

                    isSource = true;
                    al_source_all_selected_nodes = ChooseAndCopy.RearrangerHelper.GetSourceOrTargetFoldersForSelectedNodes(sourcePath, _selectedIndex_etc, isSource);

                    if (this.excludeSelected_btn_b.Checked == true)
                    {
                        for (int i = 0; i < lb4.Items.Count; i++)
                        {
                            if (lb4.Items[i].ToString().ToLower().Contains("folder : "))
                                al_excluded_folders.Add(lb4.Items[i].ToString().Remove(0, ChooseAndCopy.RearrangerHelper.folderLabel.Length));                                
                            else
                            {
                                //write error log here -- only folders should be selected for batch mode
                                MessageBox.Show("Only folders can be excluded when using Batch Mode!", "REMINDER",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                reselectNeeded = true;
                            }
                        }
                    }
                    if (!reselectNeeded)
                    {
                        if (al_source_all_selected_nodes.Count == al_target_all_selected_nodes.Count)
                        {
                            string _sourcePath;
                            string _targetPath;

                            for (int i = 0; i < al_source_all_selected_nodes.Count; i++)
                            {
                                _sourcePath = al_source_all_selected_nodes[i].ToString();
                                _targetPath = al_target_all_selected_nodes[i].ToString();

                                RearrangerHelper.Copy_BOP_ETC_Files(_sourcePath, _targetPath, al_excluded_folders, tabPage_etc, this.filter_out_sys_altsys_files_ckb.Checked, isBatchMode);
                            }

                            
                            foreach (string _target_path_to_open in al_target_all_selected_nodes)
                            {
                                if (this.open_etc_folder_cbx.Checked)
                                {
                                    openFolder(_target_path_to_open);
                                }
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("\"Only include selected subfolders/files from the source folder\" does NOT support Batch Mode!", "REMINDER",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else //for just one at one time
            {
                isBatchMode = false;
                ArrayList al_source = new ArrayList();
                if (this.includesAll_btn_b.Checked == true || this.excludeSelected_btn_b.Checked == true)
                {
                    for (int i = 0; i < lb3.Items.Count; i++)
                    {
                        al_source.Add(lb3.Items[i].ToString());
                    }
                }
                else if (this.onlySelected_btn_b.Checked == true)
                {
                    for (int i = 0; i < lb4.Items.Count; i++)
                    {
                        al_source.Add(lb4.Items[i].ToString());
                    }
                }


                RearrangerHelper.Copy_BOP_ETC_Files(sourcePath, targetPath, al_source, tabPage_etc, this.filter_out_sys_altsys_files_ckb.Checked, isBatchMode);

                if (this.open_etc_folder_cbx.Checked)
                {
                    openFolder(targetPath);
                }
            }
        }

        private static void openFolder(string targetPath)
        {
            string myPath = targetPath;
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void SourceFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.ShowReadOnly = true;


            dlgOpenFile.ShowDialog();
            this.SourceFileName.Text = dlgOpenFile.FileName;
        }

        private void TargetFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.ShowReadOnly = true;


            dlgOpenFile.ShowDialog();
            this.BOP_sysinitFileName.Text = dlgOpenFile.FileName;

        }

        private void altsysinitFilePath_TZ_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile2 = new OpenFileDialog();
            dlgOpenFile2.ShowReadOnly = true;


            dlgOpenFile2.ShowDialog();
            this.altsysinitFilePath.Text = dlgOpenFile2.FileName;
        }

        private void sysinitFilePath_TZ_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile3 = new OpenFileDialog();
            dlgOpenFile3.ShowReadOnly = true;


            dlgOpenFile3.ShowDialog();
            this.sysinitFileFath.Text = dlgOpenFile3.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { this.comboBox1.Enabled = true; }
            else
            { this.comboBox1.Enabled = false; }
        }

        private void ReplaceInfoBtn_Click(object sender, EventArgs e)
        {
            _selectedIndex = Convert.ToInt16(comboBox1.SelectedItem);
            ArrayList al_source = new ArrayList();
            ArrayList al_dest = new ArrayList();

            if (_selectedIndex >= 1)
            {
                al_source = ReplaceInfo.ReplacementHelper.GetSourceDirectoriesOfSysinitFilesForSelectedNodes(this.SourceFileName.Text, _selectedIndex);
                al_dest = ReplaceInfo.ReplacementHelper.GetTargetDirectoriesOfBOPSysinitFilesForSelectedNodes(this.BOP_sysinitFileName.Text, _selectedIndex);

                if (al_dest.Count == al_source.Count && al_source.Count == _selectedIndex)
                {
                    for (int i = 0; i < _selectedIndex; i++)
                    {
                        string sourceFileName = al_source[i].ToString();
                        string targetFileName = al_dest[i].ToString();
                        int nodeNumber = i + 1;

                        Hashtable ht_extractedInfo = ReplaceInfo.ReplacementHelper.ReadSourceFile(sourceFileName, nodeNumber);

                        ReplaceInfo.ReplacementHelper.ReadTargetFiles(targetFileName, this.altsysinitFilePath.Text, this.sysinitFileFath.Text, ht_extractedInfo, this.openFilesCHKBOX.Checked);

                    }
                }
                else
                {
                    //write error log -- cannot get matched source sysinit files and target BOP_sysinit files, please check!!!
                }
            }


            else
            {
                Hashtable ht_extractedInfo = ReplaceInfo.ReplacementHelper.ReadSourceFile(this.SourceFileName.Text, 999);

                ReplaceInfo.ReplacementHelper.ReadTargetFiles(this.BOP_sysinitFileName.Text, this.altsysinitFilePath.Text, this.sysinitFileFath.Text, ht_extractedInfo, this.openFilesCHKBOX.Checked);

            }
        }

        int _selectedIndex;
        int _selectedIndex_etc;
        int _selectedIndex_bop;

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedIndex = Convert.ToInt16(comboBox1.SelectedItem);//.SelectedIndex;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Refresh();
            System.Object[] ItemObject = new System.Object[13];
            for (int i = 1; i <= 13; i++)
            {
                ItemObject[i - 1] = i;
            }
            if (!comboBox1.Items.Contains(12))
                comboBox1.Items.AddRange(ItemObject);

            
        }

        private void checkBox_bop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { this.comboBox2.Enabled = true; }
            else
            { this.comboBox2.Enabled = false; }

        }

        private void comboBox_bop_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedIndex_bop = Convert.ToInt16(comboBox2.SelectedItem);
        }

        private void comboBox_bop_DropDown(object sender, EventArgs e)
        {
            comboBox2.Refresh();
            System.Object[] ItemObject = new System.Object[13];
            for (int i = 1; i <= 13; i++)
            {
                ItemObject[i - 1] = i;
            }
            if (!comboBox2.Items.Contains(12))
                comboBox2.Items.AddRange(ItemObject);
        }

        private void checkBox_etc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            { this.comboBox3.Enabled = true; }
            else
            { this.comboBox3.Enabled = false; }
        }

        

        private void comboBox_etc_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedIndex_etc = Convert.ToInt16(comboBox3.SelectedItem);
        }

        private void comboBox_etc_DropDown(object sender, EventArgs e)
        {
            comboBox3.Refresh();
            System.Object[] ItemObject = new System.Object[13];
            for (int i = 1; i <= 13; i++)
            {
                ItemObject[i - 1] = i;
            }
            if (!comboBox3.Items.Contains(12))
                comboBox3.Items.AddRange(ItemObject);
        }

                
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://notepad-plus-plus.org/download");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://winmerge.org/downloads/");            
        }
    }    
}