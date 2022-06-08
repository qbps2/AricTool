using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchStringProject
{
    public partial class SearchStringProject : Form
    {
        public class SearchResult
        {
            public string LineData { get; set; }
            public int LineNumber { get; set; }
        }

        ConfigInfo configInfo;
        List<string> inputLines;
        bool IsOpenFile = false;

        private void checkUI()
        {
            checkBoxShowLine.Checked = configInfo.IsShowLine;
            checkBoxMultiResult.Checked = configInfo.IsMultiResult;

            int Count = configInfo.ListSearchSettings.Count;
            for (int i = 0; i < 3 - Count ; i++)
            {
                configInfo.ListSearchSettings.Add(new SearchSetting());
            }

            textBoxSearchString1.Text = configInfo.ListSearchSettings[0].SearchString;
            textBoxSearchString2.Text = configInfo.ListSearchSettings[1].SearchString;
            textBoxSearchString3.Text = configInfo.ListSearchSettings[2].SearchString;

            checkBoxPrintLine1.Checked = configInfo.ListSearchSettings[0].IsPrintLine;
            checkBoxPrintLine2.Checked = configInfo.ListSearchSettings[1].IsPrintLine;
            checkBoxPrintLine3.Checked = configInfo.ListSearchSettings[2].IsPrintLine;

            if (IsOpenFile == true)
            {
                labelFileName.Text = Path.GetFileName(lastInputFile);
                buttonExecute.Enabled = true;
            }
        }

        public SearchStringProject()
        {
            InitializeComponent();
            configInfo = new ConfigInfo();
            configInfo = ConfigClass.OpenConfig("config.json");
            inputLines = new List<string>();
            checkUI();
        }

        string lastInputFile = "";
        string lastOutputFile = "";
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open  File";
            ofd.Filter = "file(*.*)|*.*";

            var WorkPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            if(ofd.InitialDirectory == "")
            {
                if(configInfo.LastPath == "" || configInfo.LastPath == null)
                {
                    ofd.InitialDirectory = WorkPath;
                }
                else
                {
                    ofd.InitialDirectory = configInfo.LastPath;
                }
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lastInputFile = ofd.FileName;
                IsOpenFile = true;
            }
            else
            {
                return;
            }

            configInfo.LastPath = Path.GetDirectoryName(ofd.FileName);

            SaveConfig();
            checkUI();

        }

        private void SaveConfig()
        {
            configInfo.IsShowLine = checkBoxShowLine.Checked;
            configInfo.IsMultiResult = checkBoxMultiResult.Checked;
            
            configInfo.ListSearchSettings[0].SearchString = textBoxSearchString1.Text;
            configInfo.ListSearchSettings[1].SearchString = textBoxSearchString2.Text;
            configInfo.ListSearchSettings[2].SearchString = textBoxSearchString3.Text;

            configInfo.ListSearchSettings[0].IsPrintLine = checkBoxPrintLine1.Checked;
            configInfo.ListSearchSettings[1].IsPrintLine = checkBoxPrintLine2.Checked;
            configInfo.ListSearchSettings[2].IsPrintLine = checkBoxPrintLine3.Checked;

            ConfigClass.SaveConfig(configInfo, "config.json");
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (lastInputFile == "")
            {
                return;
            }
            string searchString1 = textBoxSearchString1.Text.ToLower();
            string searchString2 = textBoxSearchString2.Text.ToLower();
            string searchString3 = textBoxSearchString3.Text.ToLower();

            string appendLine1, appendLine2, appendLine3;

            appendLine1 = checkBoxPrintLine1.Checked == true ? "\n" : "";
            appendLine2 = checkBoxPrintLine2.Checked == true ? "\n" : "";
            appendLine3 = checkBoxPrintLine3.Checked == true ? "\n" : "";

            inputLines.Clear();
            foreach (string line in System.IO.File.ReadLines(lastInputFile, Encoding.UTF8))
            {
                inputLines.Add(line);
            }

            List<SearchResult> listSearchResult = new List<SearchResult>();
            for (int i = 0 ; i < inputLines.Count ; i++)
            {
                bool isFound = false;
                if (searchString1 == "" ? false : inputLines[i].ToLower().Contains(searchString1))
                {
                    isFound = true;
                    listSearchResult.Add(new SearchResult { LineNumber = i + 1, LineData = inputLines[i] + appendLine1});
                }

                if( searchString2 == "" ? false : inputLines[i].ToLower().Contains(searchString2))
                {
                    if (checkBoxMultiResult.Checked == false)
                    {
                        if (isFound == false)
                        {
                            listSearchResult.Add(new SearchResult { LineNumber = i + 1, LineData = inputLines[i] + appendLine2 });
                            isFound = true;
                        }
                    }
                    else
                    {
                        listSearchResult.Add(new SearchResult { LineNumber = i + 1, LineData = inputLines[i] + appendLine2 });
                    }
                }

                if (searchString3 == "" ? false : inputLines[i].ToLower().Contains(searchString3))
                {
                    if (checkBoxMultiResult.Checked == false)
                    {
                        if (isFound == false )
                        {
                            listSearchResult.Add(new SearchResult { LineNumber = i + 1, LineData = inputLines[i] + appendLine3 });
                            isFound = true;
                        }
                    }
                    else
                    {
                        listSearchResult.Add(new SearchResult { LineNumber = i + 1, LineData = inputLines[i] + appendLine3 });
                    }
                }
            }
            
            lastOutputFile = String.Format("{0}{1}.{2}", Path.Combine(Path.GetDirectoryName(lastInputFile), Path.GetFileNameWithoutExtension(lastInputFile)), "_searched", "txt" );

            StreamWriter streamWriter = new StreamWriter(lastOutputFile, false);

            for(int i = 0 ; i< listSearchResult.Count ; i++)
            { 
                if(checkBoxShowLine.Checked == true)
                {
                    streamWriter.WriteLine("{0:00000}: {1}", listSearchResult[i].LineNumber, listSearchResult[i].LineData);
                }
                else
                {
                    streamWriter.WriteLine("{0}", listSearchResult[i].LineData);
                }
            }

            streamWriter.Close();
            Process.Start(Path.GetDirectoryName(lastInputFile));

            SaveConfig();
        }

        private void createProcess(string directory, string executeName, string arguments)
        {
            Process PP1 = null;
            PP1 = new Process();
            PP1.StartInfo.WorkingDirectory = directory;
            PP1.StartInfo.FileName = executeName;
            PP1.StartInfo.Arguments = arguments;
            PP1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                PP1.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SearchStringProject_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;//调用DragDrop事件 
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void SearchStringProject_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            lastInputFile = filePaths[0];
            labelFileName.Text = lastInputFile;
            IsOpenFile = true;
            checkUI();
        }

        private void buttonOpenCompleteFile_Click(object sender, EventArgs e)
        {
            var WorkPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            createProcess(WorkPath, "notepad.exe", lastOutputFile);
        }
    }
}
