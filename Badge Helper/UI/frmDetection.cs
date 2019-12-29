using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badge_Helper
{
    public partial class frmDetection : Form
    {
        public frmDetection()
        {
            InitializeComponent();
        }

        private void frmDetection_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss");
            LoadUI();
        }
        private void LoadUI()
        {
            txtFolder.Text = DetectConfig.Instance.FolderPath;
            LoadAccountLog();
        }

        private void LoadAccountLog()
        {
            listBox1.Items.Clear();
            string rootPath = DetectConfig.Instance.FolderPath;
            if (string.IsNullOrEmpty(rootPath))
                return;
            if (!Directory.Exists(rootPath))
                return;

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

        private void bBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DetectConfig.Instance.FolderPath = fbd.SelectedPath;
                DetectConfig.Instance.Save();
            }
            LoadUI();
        }

        

        private void bDetect_Click(object sender, EventArgs e)
        {
            ReadChatLogFile();
        }

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

        private void ProcessContent(string content)
        {
            if (string.IsNullOrEmpty(lblDateTime.Text))
                return;


            BadgeManager.Load();
            DateTime startDateTime = DateTime.Parse(lblDateTime.Text);




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

            MessageBox.Show("Chat log file detection completed! -- go back to use the 'Badges Matches' button from the main menu!");

            LoadUI();
        }
    }
}
