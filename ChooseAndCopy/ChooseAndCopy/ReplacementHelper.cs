using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReplaceInfo
{
    public class ReplacementHelper
    {
        public static Hashtable ReadSourceFile(string sourcefilePath, int nodeNumber)
        {           
            ArrayList al = new ArrayList();
            if (sourcefilePath.Contains("Press button below to choose"))
                sourcefilePath = "";

            if (sourcefilePath != "")
            {
                //string sourcePath = sourcefilePath;
                string[] lines = System.IO.File.ReadAllLines(sourcefilePath);
                

                al.AddRange(lines);
                
            }

            Hashtable ht = new Hashtable();
            if (al.Count >= 1)
                ht = FindInfoInSourceFile(al, sourcefilePath, nodeNumber);

            return ht;
            
        }

        static public void ReadTargetFiles(string BOP_sysinitFilePath, string altsysinitFilePath, string sysinitFilePath, Hashtable ht, bool openFile)
        {
            if (BOP_sysinitFilePath.Contains("Press button below to choose"))
                BOP_sysinitFilePath = "";
            if (altsysinitFilePath.Contains("Press button below to choose"))
                altsysinitFilePath = "";
            if (sysinitFilePath.Contains("Press button below to choose"))
                sysinitFilePath = "";


            ArrayList al_BOP_sysinit = new ArrayList();
            if (BOP_sysinitFilePath != "")
            {
                //string targetPath = targetFilePath;
                string[] lines = System.IO.File.ReadAllLines(BOP_sysinitFilePath);
                
                al_BOP_sysinit.AddRange(lines);
            }

            ArrayList al_altsysinit = new ArrayList();
            if (altsysinitFilePath != "")
            {
                //string targetPath = targetFilePath;
                string[] lines2 = System.IO.File.ReadAllLines(altsysinitFilePath);

                al_altsysinit.AddRange(lines2);
            }

            ArrayList al_sysinit = new ArrayList();
            if (sysinitFilePath != "")
            {
                //string targetPath = targetFilePath;
                string[] lines3 = System.IO.File.ReadAllLines(sysinitFilePath);

                al_sysinit.AddRange(lines3);
            }
            modifyBOP_sysinitFile(al_BOP_sysinit, al_altsysinit, al_sysinit, ht, BOP_sysinitFilePath, altsysinitFilePath, sysinitFilePath, openFile);
            
        }

        static void modifyBOP_sysinitFile(ArrayList al_BOP_sysinit, ArrayList al_altsysinit, ArrayList al_sysinit,Hashtable ht, string BOP_sysinitFilePath, string altsysinitFilePath_TZ, string sysinitFilePath_TZ, bool OpenFile)
        {            
            //1. update the info like disk3, hd0, project in file BOP_sysinit
            if (al_BOP_sysinit.Count > 1)
            {
                if (ht.ContainsKey("project"))               
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "project=\"<rig name here>\"", "project=" + "\"" + ht["project"] + "\""));
                if (ht.ContainsKey("disk3"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "disk3=\"\"", "disk3=" + "\"" + ht["disk3"] + "\""));
                if (ht.ContainsKey("fd0"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "floppyCD=\"\"", "floppyCD=" + "\"" + ht["fd0"] + "\""));
                if (ht.ContainsKey("bitmap"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "bitmap=\"\"", "bitmap=" + "\"" + ht["bitmap"] + "\""));
                if (ht.ContainsKey("group"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "group=\"\"", "group=" + "\"" + ht["group"] + "\""));
                if (ht.ContainsKey("mqueue"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "mqueue=\"\"", "mqueue=" + "\"" + ht["mqueue"] + "\""));
                if (ht.ContainsKey("digi"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "digi=\"\"", "digi=" + "\"" + ht["digi"] + "\""));
                if (ht.ContainsKey("history"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "history=\"\"", "history=" + "\"" + ht["history"] + "\""));
                if (ht.ContainsKey("SMB"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "SMB=\"\"", "SMB=" + "\"" + ht["SMB"] + "\""));
                if (ht.ContainsKey("zytronic"))
                    File.WriteAllText(BOP_sysinitFilePath, Regex.Replace(File.ReadAllText(BOP_sysinitFilePath), "zytronic=\"\"", "zytronic=" + "\"" + ht["zytronic"] + "\""));

                if (OpenFile)
                    openFile(BOP_sysinitFilePath);
            }
        
            

            string pat_TZ = "(^export(\\s)+TZ=)+";
            Regex r_TZ = new Regex(pat_TZ, RegexOptions.IgnoreCase);
            string TZ_line = "";

            //2. update the TZ in altsysinit
            if (al_altsysinit.Count > 1)
            {
                foreach (string str in al_altsysinit)
                {
                    Match m_TZ = r_TZ.Match(str);

                    if (m_TZ.Success)
                    {
                        TZ_line = str;
                    }
                }


                if (TZ_line != "")
                {
                    File.WriteAllText(altsysinitFilePath_TZ, Regex.Replace(File.ReadAllText(altsysinitFilePath_TZ), "^" + TZ_line, "export TZ=" + ht["TZ"], RegexOptions.Multiline));
                    if(OpenFile)
                        openFile(altsysinitFilePath_TZ);
                }
            }

            //3. update the TZ in altsysinit
            if (al_sysinit.Count > 1)
            {
                TZ_line = "";
                foreach (string str in al_sysinit)
                {
                    Match m_TZ = r_TZ.Match(str);

                    if (m_TZ.Success)
                    {
                        TZ_line = str;
                    }
                }


                if (TZ_line != "")
                {
                    File.WriteAllText(sysinitFilePath_TZ, Regex.Replace(File.ReadAllText(sysinitFilePath_TZ), "^" + TZ_line, "export TZ=" + ht["TZ"], RegexOptions.Multiline));
                    if (OpenFile)
                        openFile(sysinitFilePath_TZ);
                }
            }
        }

        static void openFile(string f)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("NotePad++.exe");
                //startInfo.FileName = "WordPad.exe";
                startInfo.Arguments = f;
                //startInfo.UseShellExecute = false;
                Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show("NotePad++ is NOT installed on this Machine! You can download it from http://notepad-plus-plus.org/download/v6.5.html . It is FREE!", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            finally
            { 
            
            }
        }

        static Hashtable FindInfoInSourceFile(ArrayList al, string sourcefilePath, int nodeNumber)
        {
            Hashtable ht = new Hashtable();
            if (al.Count > 0 && sourcefilePath != "")
            {
                ArrayList result_al = new ArrayList();
                ArrayList error_al = new ArrayList();
                
                ArrayList extractedInfo_al = new ArrayList();
                //string text = "One car red car blue car";
                //string pat = @"(\w+)\s+(car)";
                string pat_Pound = "^#+";

                string pat_project = "Hydril=+";
                string pat_disk3 = "disk3+";
                string pat_fd0 = "fd0+|cd0";
                string pat_bitmap = "bitmap";
                string pat_group = "group";
                string pat_mqueue = "mqueue";
                string pat_digi = "digi";
                string pat_history = "history";
                string pat_SMB = "SMB+";
                string pat_zytronic = "zytronic";

                string pat_TZ = "TZ=+";


                // Compile the regular expression.
                Regex r_Pound = new Regex(pat_Pound, RegexOptions.None);

                Regex r_project = new Regex(pat_project, RegexOptions.None);
                Regex r_disk3 = new Regex(pat_disk3, RegexOptions.None);
                Regex r_fd0 = new Regex(pat_fd0, RegexOptions.None);
                Regex r_bitmap = new Regex(pat_bitmap, RegexOptions.IgnoreCase);
                Regex r_group = new Regex(pat_group, RegexOptions.IgnoreCase);
                Regex r_mqueue = new Regex(pat_mqueue, RegexOptions.IgnoreCase);
                Regex r_digi = new Regex(pat_digi, RegexOptions.IgnoreCase);
                Regex r_history = new Regex(pat_history, RegexOptions.IgnoreCase);
                Regex r_SMB = new Regex(pat_SMB, RegexOptions.None);
                Regex r_zytronic = new Regex(pat_zytronic, RegexOptions.IgnoreCase);

                Regex r_TZ = new Regex(pat_TZ, RegexOptions.None);

                foreach (string str in al)
                {
                    char[] charTrim = { ' ' };
                    Match m_Pound = r_Pound.Match(str.TrimStart(charTrim));
                    if (!m_Pound.Success)
                    {



                        Match m_project = r_project.Match(str);
                        Match m_disk3 = r_disk3.Match(str);
                        Match m_fd0 = r_fd0.Match(str);
                        Match m_bitmap = r_bitmap.Match(str);
                        Match m_group = r_group.Match(str);
                        Match m_mqueue = r_mqueue.Match(str);
                        Match m_digi = r_digi.Match(str);
                        Match m_history = r_history.Match(str);
                        Match m_SMB = r_SMB.Match(str);
                        Match m_zytronic = r_zytronic.Match(str);

                        Match m_TZ = r_TZ.Match(str);



                        if (!ht.Contains("project") && (m_project.Success || str.Contains("Hydril=")))
                        {
                            if (m_project.Success != str.Contains("Hydril="))
                            {
                                error_al.Add("project: " + str);
                            }

                            result_al.Add(str);
                            char[] delimiterStrings = { '/', '\'' };

                            string[] words = str.Split(delimiterStrings);
                            string projectName = words[words.Length - 1];

                            ht.Add("project", projectName);
                            extractedInfo_al.Add("project:" + projectName);
                        }

                        else if (!ht.Contains("disk3") && (m_disk3.Success || str.Contains("disk3")))
                        {
                            if (m_disk3.Success != str.Contains("disk3"))
                            {
                                error_al.Add("disk3: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("disk3", "Y");
                            extractedInfo_al.Add("disk3:Y");
                        }
                        else if (!ht.Contains("fd0") && (m_fd0.Success || str.Contains("fd0") || str.Contains("cd0")))
                        {
                            if ((m_fd0.Success != str.Contains("fd0")) && (m_fd0.Success != str.Contains("cd0")))
                            {
                                error_al.Add("floppyCD: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("fd0", "Y");
                            extractedInfo_al.Add("floppyCD:Y");
                        }
                        else if (!ht.Contains("bitmap") && (m_bitmap.Success || str.Contains("Bitmap")))
                        {

                            if (m_bitmap.Success != str.Contains("Bitmap"))
                            {
                                error_al.Add("bitmap: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("bitmap", "Y");
                            extractedInfo_al.Add("bitmap:Y");
                        }
                        else if (!ht.Contains("group") && (m_group.Success || str.Contains("Group")))
                        {
                            if (m_group.Success != str.Contains("Group"))
                            {
                                error_al.Add("group: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("group", "Y");
                            extractedInfo_al.Add("group:Y");
                        }
                        else if (!ht.Contains("mqueue") && (m_mqueue.Success || str.Contains("Mqueue")))
                        {
                            if (m_mqueue.Success != str.Contains("Mqueue"))
                            {
                                error_al.Add("mqueue: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("mqueue", "Y");
                            extractedInfo_al.Add("mqueue:Y");
                        }
                        else if (!ht.Contains("digi") && (m_digi.Success || str.Contains("digi")))
                        {
                            if (m_digi.Success != str.Contains("digi"))
                            {
                                error_al.Add("digi: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("digi", "Y");
                            extractedInfo_al.Add("digi:Y");
                        }
                        else if (!ht.Contains("history") && (m_history.Success || str.Contains("history")))
                        {
                            if (m_history.Success != str.Contains("history"))
                            {
                                error_al.Add("history: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("history", "Y");
                            extractedInfo_al.Add("history:Y");
                        }
                        else if (!ht.Contains("SMB") && (m_SMB.Success || str.Contains("SMB")))
                        {
                            if (m_SMB.Success != str.Contains("SMB"))
                            {
                                error_al.Add("SMB: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("SMB", "Y");
                            extractedInfo_al.Add("SMB:Y");
                        }
                        else if (!ht.Contains("zytronic") && (m_zytronic.Success || str.Contains("zytronic")))
                        {
                            if (m_zytronic.Success != str.Contains("zytronic"))
                            {
                                error_al.Add("zytronic: " + str);
                            }

                            result_al.Add(str);
                            ht.Add("zytronic", "Y");
                            extractedInfo_al.Add("zytronic:Y");
                        }



                        else if (!ht.Contains("TZ") && (m_TZ.Success || str.Contains("TZ")))
                        {
                            if (m_TZ.Success != str.Contains("TZ"))
                            {
                                error_al.Add("TZ: " + str);
                            }

                            result_al.Add(str);
                            Regex r = new Regex("TZ=");

                            string[] words = r.Split(str);
                            string TZ = words[words.Length - 1];
                            ht.Add("TZ", TZ);
                            extractedInfo_al.Add("TZ:" + TZ);
                        }



                    }
                    m_Pound = m_Pound.NextMatch();
                }
                writeLogFile(result_al, extractedInfo_al, error_al, sourcefilePath, nodeNumber);                
            }
            return ht;
        
        }

        static void ReplaceInfoInTargetFile()
        { }

        static void writeLogFile(ArrayList al, ArrayList extractedInfo_al, ArrayList error_al, string sourcefile, int nodeNumber)
        {
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string logfile = @"\logfile" + nodeNumber.ToString() + ".txt";
            string fullpath = currentDirectory + logfile;

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fullpath))
            {
                sw.WriteLine("");
                sw.WriteLine("CURRENT TIME: " + DateTime.Now);
                sw.WriteLine("");
                sw.WriteLine("THE INFORMATION BELOW IS FROM: " + sourcefile);
                sw.WriteLine("======================================= RELATED INFORMATION GET FROM SYSINIT FILE =======================================");
                sw.WriteLine("");
                foreach (string str in al)
                {
                    sw.WriteLine(str);
                    
                }
                sw.WriteLine("");
                
                sw.WriteLine("========================================================== END ==========================================================");
                sw.WriteLine("");
                sw.WriteLine("THE INFORMATION EXTRACTED FROM DATA ABOVE");
                
                sw.WriteLine("==================== BEGIN ======================");
                foreach (string str in extractedInfo_al)
                {
                    sw.WriteLine(str);
                }
                sw.WriteLine("===================== END =======================");
                sw.WriteLine("");
                sw.WriteLine("");

                if (error_al.Count >= 1)
                {
                    sw.WriteLine("************************************ !!! ERROR MESSAGE !!! ************************************");
                    foreach (string str in error_al)
                    {
                        sw.WriteLine(str);
                    }
                    sw.WriteLine("***********************************************************************************************");
                }
               

            }
            if (File.Exists(fullpath))
            {
                Process.Start(fullpath);
            }
        }

        public static ArrayList GetSourceDirectoriesOfSysinitFilesForSelectedNodes(string sourceDirName, int nodesNumber)
        {
            ArrayList al_source = new ArrayList();
            char[] charSplit = new char[] { '\\' };
            //string[] str_array = sourceDirName.Split(charSplit);
            ArrayList al = new ArrayList(sourceDirName.Split(charSplit));


            for (int i = 1; i <= nodesNumber; i++)
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb_withZero = new StringBuilder();
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
                        if (str.Contains("sysinit.") && index == al.Count)
                        {
                            sb.Append("sysinit.");
                            sb.Append(i.ToString());

                            sb_withZero.Append("sysinit.");
                            sb_withZero.Append(i.ToString());
                        }
                        else
                        {
                            sb.Append(str);
                            sb_withZero.Append(str);
                        }
                    }
                    if (index < al.Count)
                    {
                        sb.Append('\\');
                        sb_withZero.Append('\\');
                    }
                    
                }
                if (File.Exists(sb.ToString()))
                    al_source.Add(sb.ToString());
                else if (File.Exists(sb_withZero.ToString()))
                    al_source.Add(sb_withZero.ToString());
                else
                { 
                    //write error log
                }

            }
            return al_source;
        }

        public static ArrayList GetTargetDirectoriesOfBOPSysinitFilesForSelectedNodes(string TargetBOPSysinitName, int nodesNumber)
        {
            ArrayList al_target = new ArrayList();
            char[] charSplit = new char[] { '\\' };
            //string[] str_array = TargetBOPSysinitName.Split(charSplit);
            ArrayList al = new ArrayList(TargetBOPSysinitName.Split(charSplit));


            for (int i = 1; i <= nodesNumber; i++)
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb_withZero = new StringBuilder();
                int index = 0;
                foreach (string str in al)
                {
                    index++;
                    if (str.ToLower().Contains("node_"))
                    {
                        string[] nodePart = Regex.Split(str, "node_", RegexOptions.IgnoreCase);
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
                        if (str.Contains("BOP_sysinit.") && index == al.Count)
                        {
                            sb.Append("BOP_sysinit.");
                            sb.Append(i.ToString());

                            sb_withZero.Append("BOP_sysinit.");
                            sb_withZero.Append(i.ToString());
                        }
                        else
                        {
                            sb.Append(str);
                            sb_withZero.Append(str);
                        }
                    }
                    if (index < al.Count)
                    {
                        sb.Append('\\');
                        sb_withZero.Append('\\');
                    }

                }
                if (File.Exists(sb.ToString()))
                    al_target.Add(sb.ToString());
                else if (File.Exists(sb_withZero.ToString()))
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
