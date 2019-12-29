using System;

using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Badge_Helper
{
    public partial class zzForm1 : Form
    {
        public zzForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"C:\Temp\testcoh\";

            txtTequillaPath.Text = @"C:\Program Files (x86)\Tequilla";

            BadgeManager.Load();

            LoadTabs();
        }


        private void LoadTabs()
        {
            //string dataFolder = @"C:\CodeEnv\Xeaonsoft\CoH Stuff\Badge Helper\Badge Helper\Data";
            //tabControlGrp.TabPages.Clear();

            //string[] files = Directory.GetFiles(dataFolder, "*.txt");
            //foreach (string file in files)
            //{
            //    //string fileName = Path.GetFileNameWithoutExtension(file);
            //    tabControlGrp.TabPages.Add(new MyTabPage(file, tabControlGrp));
            //}

            //int count = BadgeManager.List.Count(a => a.Selected);
            //lblTotalBadgeCount.Text = $"Total Badges:{count}";

        }

        private void DeleteFiles()
        {
            string bindPath = textBox1.Text;
            string[] files = Directory.GetFiles(bindPath, "bind*.txt");
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch { }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DeleteFiles();


            string bindPath = textBox1.Text;
            textBox2.Text = $"/bind_Load_file \"{Path.Combine(bindPath, $"bind0.txt")}\""; ;

            int fileCpt = 0;

            const int loopMax = 12;
            //const int loopMax = 5;

            //for (int i = 0; i < 1600; i += loopMax)
            for (int i = 0; i < 2400; i += loopMax)
            {
                string currentFilePath = Path.Combine(bindPath, $"bind{fileCpt}.txt");
                string newFilePath = Path.Combine(bindPath, $"bind{fileCpt + 1}.txt");

                string iterString = string.Empty;
                for (int j = 0; j < loopMax; j++)
                {
                    iterString += $"set_title {i + j}$$";
                    //iterString += $"local b:{i + j}$$set_title {i + j}$$";
                }

                string content = $"ctrl+m \"{iterString}bind_Load_file {newFilePath}\"";

                File.WriteAllText(currentFilePath, content);
                fileCpt++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string rootPath = txtTequillaPath.Text;
            string ymd = DateTime.Today.ToString("yyyy-MM-dd");
            string[] founds = Directory.GetFiles(rootPath, $"chatlog {ymd}.txt", SearchOption.AllDirectories);


            LogFileItem.List.Clear();

            foreach (string found in founds)
            {
                string rightPart = found.Replace(rootPath, string.Empty);
                string[] parts = rightPart.Split('\\');

                //parts.ToList().Where(a => !string.IsNullOrEmpty(a)).First()
                LogFileItem lfi = new LogFileItem { File = found };
                lfi.PlayerName = parts.ToList().Where(a => !string.IsNullOrEmpty(a)).First();
                listBox1.Items.Add(lfi.PlayerName);


                LogFileItem.List.Add(lfi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {





            //string content = File.ReadAllText(lfi.File);
            //fileSystemWatcher1.Path = Path.GetDirectoryName(lfi.File);
            //fileSystemWatcher1.Filter = Path.GetFileName(lfi.File);
        }



        //has been selected as new title.
        const string BadgeLine = "has been selected as new title.";

        private void ReadChatLogFile()
        {
            string selection = $"{listBox1.SelectedItem}";
            if (string.IsNullOrEmpty(selection))
            {
                MessageBox.Show("No Selection!");
                return;
            }

            var lfi = LogFileItem.List.Single(a => a.PlayerName == selection);


            if (lfi == null)
            {
                MessageBox.Show("lfi is null"); ;
                return;

            }

            string path = lfi.File;
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd();

                ProcessContent(content);
                //txtTestContent.Text = content;
            }
        }
        //ctrl+m "local $name$$set_title 0$$bind_Load_file C:\Temp\testcoh\bind1.txt"

        private void ProcessContent(string content)
        {
            if (string.IsNullOrEmpty(lblStartDateTime.Text))
                return;


            BadgeManager.Load();
            DateTime startDateTime = DateTime.Parse(lblStartDateTime.Text);




            string[] lines = content.Split('\r');


            var badgesEntries = lines.Where(a => a.EndsWith(BadgeLine));

            foreach (string badgeEntry in badgesEntries)
            {
                //"2019-12-28 12:37:03 " -- cut first 20
                string date = badgeEntry.Substring(0, 20);
                DateTime lineDate = DateTime.Parse(date);
                if (lineDate > startDateTime)
                {
                    string line = badgeEntry.Substring(20, badgeEntry.Length - 20);
                    line = line.Replace(BadgeLine, string.Empty);
                    //sb.AppendLine(line);

                    BadgeItem b = new BadgeItem { Name = line, Selected = true };
                    BadgeManager.Add(b);
                }
            }



            BadgeManager.Save();


            LoadTabs();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadChatLogFile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblStartDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
