using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace CopyAndRemove
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

            return result_al;
        }

        public static void CopyBopConfigFiles(string sourcePath, string targetPath, ArrayList al_source)
        { 
            //System.IO.File.Move(
            foreach (string str in al_source)
            {
                if (str.Contains(folderLabel))
                {
                    //System.IO.Directory.Move(sourcePath + "\\" + str.Remove(0, folderLabel.Length), sourcePath);
                    DirectoryCopy(sourcePath + "\\" + str.Remove(0, folderLabel.Length), targetPath, true);
                }
                else
                {
                    System.IO.File.Copy(sourcePath + "\\" + str, targetPath + "\\" + str, true);
                }
            }        
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
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
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath,true);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
