using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CopyAndRemove
{    
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

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
            LoadAvailableItems(al);

           
        }
        private void LoadAvailableItems(ArrayList al)
        {
            try
            {
                this.lb1.Items.Clear();
                foreach (object o in al)
                {
                    FolderFile f = (FolderFile)o;
                    string filename = f.name;
                    filename = truncateItemName(filename);
                    //string filetype = f.ft.ToString();

                    //RearrangerHelper rah = new RearrangerHelper();

                    if (f.ft == fileType.folder)
                        filename = RearrangerHelper.folderLabel + filename;

                    lb1.Items.Add(filename);
                   
                }
            }
            catch(Exception ex)
            { string str = "Exception detected populating the available files list"; }

        }

        private string truncateItemName(string name)
        {
            int length = this.sourceBinFolder_lable.Text.Length;
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
            if(binSourceFolder.SelectedPath.Contains("bin\\bop_config"))            
            this.bop_config_target_folder_label.Text = binSourceFolder.SelectedPath;
            else
            this.bop_config_target_folder_label.Text = "Please choose target folder \"bin\\bop_config\"!";
        }

        private void copy_bop_config_btn_Click(object sender, EventArgs e)
        {
            string targetPath = this.bop_config_target_folder_label.Text;
            string sourcePath = this.sourceBinFolder_lable.Text;
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
            
            RearrangerHelper.CopyBopConfigFiles(sourcePath, targetPath, al_source);

            if (this.open_bop_config_folder_cbx.Checked)
            {
                string myPath = targetPath;
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = myPath;
                prc.Start();
            }
        }

        private void includesAll_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.includesAll_btn.Checked == true)
            {
                ArrayList al = new ArrayList();
                al = RearrangerHelper.GetFoldersAndFilesInSourceBinFolder(this.sourceBinFolder_lable.Text);
                LoadAvailableItems(al);

                this.lb2.Items.Clear();
            }
            
        }
    }

    
}