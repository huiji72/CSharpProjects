using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChooseAndCopy
{
    public enum fileType
    { file, folder };

    public class FolderFile
    {
        public string name;
        public fileType ft;
    }

    
    class RearrangerHelper
    {
        public static string folderLabel = "FOLDER : ";
        public static ArrayList GetFoldersAndFilesInSourceBinFolder(string sourceBinPath)
        {
            ArrayList al = new ArrayList();
            ArrayList result_al = new ArrayList();
            if (sourceBinPath != "")
            {

                

                al.AddRange(Directory.GetDirectories(sourceBinPath));
                foreach (string fileStr in al)
                {
                    FolderFile f = new FolderFile();
                    f.name = fileStr;
                    f.ft = fileType.folder;

                    result_al.Add(f);
                }


                al.AddRange(Directory.GetFiles(sourceBinPath));

                foreach (string fileStr in al)
                {
                    FolderFile f = new FolderFile();
                    FileAttributes attr = File.GetAttributes(fileStr);
                    if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        f.name = fileStr;
                        f.ft = fileType.file;
                        result_al.Add(f);
                    }


                }
                //foreach (object o in result_al)
                //{
                //    FolderFile f = (FolderFile)o;
                //    string filename = f.name;
                //    string filetype = f.ft.ToString();
                //}
            }
            return result_al;

        }
        public static void Copy_BOP_ETC_Files(string sourcePath, string targetPath, ArrayList al_source, TabPage tp, bool filterOutFiles, bool isBatchMode)
        { 
            
            string filename = "";
            ArrayList al_excludedFolders = new ArrayList();
            if (isBatchMode)
            {
                DirectoryCopy(sourcePath, targetPath, true, filterOutFiles, al_source, isBatchMode);
            }
            else
            {
                foreach (string str in al_source)
                {
                    filename = str;
                    if (tp.Name == "tabPage_etc" && filterOutFiles == true)
                    {
                        filename = filterFileName(str);
                    }

                    if (filename != "")
                    {
                        if (str.Contains(folderLabel))
                        {
                            //System.IO.Directory.Move(sourcePath + "\\" + str.Remove(0, folderLabel.Length), sourcePath);
                            DirectoryCopy(sourcePath + "\\" + str.Remove(0, folderLabel.Length), targetPath + "\\" + str.Remove(0, folderLabel.Length), true, filterOutFiles, al_excludedFolders, isBatchMode);
                        }
                        else
                        {
                            filename = sourcePath + "\\" + filename;
                            try
                            {
                                System.IO.File.Copy(sourcePath + "\\" + str, targetPath + "\\" + str, true);
                            }
                            catch (Exception ex)
                            {
                                //string str = "Exception detected when populating the available files list";
                                throw new Exception(filename + " doesn't exist!!!");
                                MessageBox.Show(filename + " doesn't exist!!!");
                            }
                            finally
                            {
                                //MessageBox mb = new MessageBox
                                //MessageBox.Show(filename + " doesn't exist!!!");
                            }

                        }
                    }
                }
            }        
        }

        private static string filterFileName(string str)
        {
            string filename = str;
            string pat_sys = "(^sys)+";
            string pat_altsys = "(^altsys)+";
            string pat_netstart = "(^netstart)+";
            Regex r_sys = new Regex(pat_sys, RegexOptions.IgnoreCase);
            Regex r_altsys = new Regex(pat_altsys, RegexOptions.IgnoreCase);
            Regex r_netstart = new Regex(pat_netstart, RegexOptions.IgnoreCase);

            Match m_sys = r_sys.Match(str);
            Match m_altsys = r_altsys.Match(str);
            Match m_netstart = r_netstart.Match(str);


            if (m_sys.Success || m_altsys.Success || m_netstart.Success)
            {
                filename = "";
            }
            return filename;
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool filterOutFiles, ArrayList al_excludedFolders, bool isBatchMode)
        {
            // Get the subdirectories for the specified directory.
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                DirectoryInfo[] dirs = dir.GetDirectories();


                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                // If the destination directory doesn't exist, create it. 
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                string filename = "";
                foreach (FileInfo file in files)
                {
                    filename = file.Name;

                    if (filterOutFiles)
                        filename = filterFileName(filename);

                    if (filename != "")
                    {
                        string temppath = Path.Combine(destDirName, file.Name);
                        file.CopyTo(temppath, true);
                    }
                }

                // If copying subdirectories, copy them and their contents to new location. 
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        bool applicable = true;

                        if (isBatchMode)
                        {
                            foreach (string str in al_excludedFolders)
                            {
                                if (subdir.FullName == sourceDirName + "\\" + str)
                                {
                                    applicable = false;
                                }
                            }
                        }
                        if (applicable)
                            DirectoryCopy(subdir.FullName, temppath, copySubDirs, filterOutFiles, al_excludedFolders,isBatchMode);
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Source directory does not exist or could not be found: "
                        + sourceDirName);
            }

            finally
            {
                
            }
        }

        /*
        public static ArrayList GetSourceDirectoriesOfAllNodes(string sourceDirName, int nodesNumber)
        {
            ArrayList al_source = new ArrayList();
            char[] charSplit = new char[] { '\\'};
            string[] str_array = sourceDirName.Split(charSplit);
            ArrayList al = new ArrayList(sourceDirName.Split(charSplit));
           

            for (int i = 1; i <= nodesNumber; i++)
            { 
                StringBuilder sb = new StringBuilder();
                int index = 0;
                foreach (string str in al)
                {
                    index++;
                    if (str.ToLower().Contains("node"))
                    {
                        string[] nodePart = Regex.Split(str, "node", RegexOptions.IgnoreCase);
                        if (nodePart.Length > 1)
                        {
                            sb.Append(nodePart[0]);
                        }
                        else
                        {
                            //write error log
                        }
                        string[] _node = str.Split(nodePart, StringSplitOptions.RemoveEmptyEntries);
                        if (_node.Length == 1)
                        {
                            sb.Append(_node[0]);
                        }
                        else
                        {
                            //write error log
                        }
                        try
                        {
                            if (Convert.ToInt32(nodePart[nodePart.Length - 1]) > 1)
                            {
                                sb.Append(i.ToString());
                            }

                            else
                            {
                                //write error log
                            }
                        }
                        catch
                        { 
                            //write error log
                        }
                        finally
                        { }
                    }
                    else
                    {
                        sb.Append(str);
                    }
                    if (index < al.Count)
                        sb.Append('\\');
                }
                al_source.Add(sb.ToString());
            }
            return al_source;

        }
         */

        public static ArrayList GetSourceOrTargetFoldersForSelectedNodes(string TargetOrSourceFolder, int nodesNumber, bool isSource)
        {
            string nodeType = "";
            if (isSource)
                nodeType = "node";
            else
                nodeType = "node_";

            ArrayList al_target = new ArrayList();
            char[] charSplit = new char[] { '\\' };
            //string[] str_array = TargetBOPSysinitName.Split(charSplit);
            ArrayList al = new ArrayList(TargetOrSourceFolder.Split(charSplit));


            for (int i = 1; i <= nodesNumber; i++)
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb_withZero = new StringBuilder();
                int index = 0;
                foreach (string str in al)
                {
                    index++;
                    if (str.ToLower().Contains(nodeType))
                    {
                        string[] nodePart = Regex.Split(str, nodeType, RegexOptions.IgnoreCase);
                        if (nodePart.Length > 1)
                        {
                            sb.Append(nodePart[0]);
                            sb_withZero.Append(nodePart[0]);
                        }
                        else
                        {
                            //write error log
                        }
                        string[] _node = str.Split(nodePart, StringSplitOptions.RemoveEmptyEntries);
                        if (_node.Length == 1)
                        {
                            sb.Append(_node[0]);
                            sb_withZero.Append(_node[0]);
                        }
                        else
                        {
                            //write error log
                        }
                        try
                        {
                            if (Convert.ToInt32(nodePart[nodePart.Length - 1]) >= 1)
                            {
                                sb.Append(i.ToString());
                                sb_withZero.Append("0");
                                sb_withZero.Append(i.ToString());
                            }

                            else
                            {
                                //write error log
                            }
                        }
                        catch
                        {
                            //write error log
                        }
                        finally
                        { }
                    }
                    else
                    {
                        sb.Append(str);
                        sb_withZero.Append(str);
                    }
                    
                    if (index < al.Count)
                    {
                        sb.Append('\\');
                        sb_withZero.Append('\\');
                    }

                }

                DirectoryInfo dir = new DirectoryInfo(sb.ToString());
                DirectoryInfo dir_withZero = new DirectoryInfo(sb_withZero.ToString());

                if (dir.Exists) 
                    al_target.Add(sb.ToString());
                else if (dir_withZero.Exists)
                    al_target.Add(sb_withZero.ToString());
                else
                {
                    //write error log -- cannot find BOP_sysinit.n file at ...
                }

            }
            return al_target;

        }
    }
}
