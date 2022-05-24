using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace AutoBackUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadPaths(@"BackUpPath.xml", "BackUpTime.xml");            
            timer1.Interval = 60000;
            timer1.Tick += new EventHandler(TimerEventProcessor);
            timer1.Start();

            notifyIcon2.BalloonTipTitle = "AutoBackUp";
            notifyIcon2.BalloonTipText = "AutoBackUp свернуто";
            notifyIcon2.Text = "AutoBackUp";

        }

        private void TimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
           if (DateTime.Now.Hour== (int)hours.Value && DateTime.Now.Minute == (int)minutes.Value)
            {
                timer2.Interval = 1000;
                timer2.Tick += new EventHandler(RefreshCounter);
                timer2.Start();
                progressBarCountRows.Maximum = BackUpFolders.RowCount - 1;
                progressBarCountRows.Value = 0;
                CopyDirectories();
            }

        }



        public void ReadPaths(in string path, in string path2)
        {


            List<BackUpItem> backUpItemSet = new List<BackUpItem>();
            List<int> backUpTime = new List<int>();
            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<BackUpItem>));
                XmlSerializer xmlDeserializerTime = new XmlSerializer(typeof(List<int>));
                using (FileStream fs = new FileStream(path, FileMode.Open))

                {
                    backUpItemSet = xmlDeserializer.Deserialize(fs) as List<BackUpItem>;
                   
                }

                using (FileStream fs = new FileStream(path2, FileMode.Open))
                {
                    backUpTime = xmlDeserializerTime.Deserialize(fs) as List<int>;
                }               

                foreach (var backUp in backUpItemSet)
                {
                    DataGridViewRow row = (DataGridViewRow)BackUpFolders.Rows[0].Clone();
                    row.Cells[0].Value = backUp.BackUpPathDeparture;
                    row.Cells[1].Value = backUp.BackUpPathDestanation;

                    BackUpFolders.Rows.Add(row);
                }

                // Set backUp time
                if (backUpTime.Count == 2)
                {
                    hours.Value = backUpTime[0];
                    minutes.Value = backUpTime[1];
                }
            }
        }

        

        public class BackUpItem
        {
            public string BackUpPathDeparture { get; set; }
            public string BackUpPathDestanation { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(RefreshCounter);
            timer2.Start();
            progressBarCountRows.Maximum = BackUpFolders.RowCount-1;
            progressBarCountRows.Value = 0;
           CopyDirectories();

           
            //MessageBox.Show("Успешно");
        }
        public void CopyDirectories()
        {
            CopyDirectoriesAsync();
        }    
           
        

        private void RefreshCounter(Object myObject,
                                         EventArgs myEventArgs)
        {
            progressBarElems.Value = Counter.count;

        }

        public async Task CopyDirectoriesAsync()
        {       

            foreach (DataGridViewRow row in BackUpFolders.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    int countFiles = 0;
                   CountFiles(row.Cells[0].Value.ToString(), ref countFiles);
                   progressBarElems.Maximum = countFiles;
                    progressBarElems.Value = 0;
                    await Task.Run(() => CopyDirectory(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), true));
                    // var directories = System.IO.Directory.GetDirectories(row.Cells[0].Value.ToString());                
                   
                    progressBarCountRows.Increment(1);
                    
                }
            }
            MessageBox.Show(String.Format("Успешно! \n кол-во перенесённых файлов - {0} \n общий объем перенесенных данных - {1}", Counter.files, Counter.size/1000000.0));
            timer2.Stop();
            Counter.files = 0;
            Counter.size = 0;

        }

        public void CountFiles(string sourceDir,ref int countFiles)
        {            
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Get the files in the source directory and copy to the destination directory
            countFiles += dir.GetFiles().Length;            

                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(sourceDir, subDir.Name);
                CountFiles(newDestinationDir, ref countFiles);
                }
            
        }

        public void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                //string sourceFilePath = Path.Combine(sourceDir, file.Name);
                if (File.Exists(targetFilePath)) {
                    if (file.LastWriteTime> File.GetLastWriteTime(targetFilePath)) {
                        File.Delete(targetFilePath);
                        file.CopyTo(targetFilePath);
                        Counter.files++;
                        Counter.size += file.Length;
                    }
                }
                else
                {
                    file.CopyTo(targetFilePath);
                    Counter.files++;
                    Counter.size += file.Length;
                }
                Counter.count++;
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
            //MessageBox.Show(sourceDir);
        }
        public static void RenameFiles(string[] directories, string prevName, string nextName)
        {
            if (directories.Length > 0)
            {
                foreach (var directory in directories)
                {
                    var files = System.IO.Directory.GetFiles(directory);
                    if (files.Length > 0)
                    {
                        foreach (var file in files)
                        {
                            var fileNameArr = file.Split('\\');
                            var lastElem = fileNameArr[fileNameArr.Length - 1];
                            if (lastElem.Contains(prevName))
                            {
                                var newFileName = file.Replace(prevName, nextName);
                                System.IO.Directory.Move(file, newFileName);
                            }
                        }
                    }
                    var subDir = System.IO.Directory.GetDirectories(directory);
                    RenameFiles(subDir, prevName, nextName);
                }
            }
        }

        private void BackUpFolders_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            MessageBox.Show("CellValuePushed");
        }

        private void BackUpFolders_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MessageBox.Show("RowAdded");
        }

        private void BackUpFolders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("RowAdded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("BackUpPath.xml")) File.Delete("BackUpPath.xml");
            if (File.Exists("BackUpPath.xml")) File.Delete("BackUpTime.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BackUpItem>));
            XmlSerializer xmlSerializerTime = new XmlSerializer(typeof(List<int>));
            List<BackUpItem> backUpItemSet = FillArray();
            List<int> backUpTime = GetTime().ToList();
            using (FileStream fs = new FileStream("BackUpPath.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, backUpItemSet);

            }
            using (FileStream fs = new FileStream("BackUpTime.xml", FileMode.OpenOrCreate))
            {
                xmlSerializerTime.Serialize(fs, backUpTime);
            }
        }

        public int[] GetTime()
        {
            int[] time = new int[] { (int)hours.Value, (int)minutes.Value };
            return time;
        }

        public List<BackUpItem> FillArray()
        {
            List<BackUpItem> backUpItemSet = new List<BackUpItem>();
            foreach (DataGridViewRow row in BackUpFolders.Rows)
            {
                if (row.Cells[0].Value!=null)
                backUpItemSet.Add(new BackUpItem() { BackUpPathDeparture = row.Cells[0].Value.ToString(), BackUpPathDestanation = row.Cells[1].Value.ToString() });
            }
            return backUpItemSet;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundMode_Click(object sender, EventArgs e)
        {            
            WindowState = FormWindowState.Minimized;
            this.Hide();
            notifyIcon2.Visible = true;            
            notifyIcon2.ShowBalloonTip(3000);
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }

}
