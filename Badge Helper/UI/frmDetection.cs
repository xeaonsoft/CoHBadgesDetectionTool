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
            //lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss");
            LoadUI();
        }
        private void LoadUI()
        {
            txtFolder.Text = DetectConfig.Instance.FolderPath;
            LoadAccountsListing();
        }

        private void LoadAccountsListing()
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


                LogFileItem lfi = new LogFileItem { File = found };
                lfi.GlobalName = parts.ToList().Where(a => !string.IsNullOrEmpty(a)).First();
                lfi.FetchData();

                if (string.IsNullOrEmpty(lfi.LocalName))
                    continue;

                listBox1.Items.Add(lfi.CombinedName);

                LogFileItem.List.Add(lfi);
            }


            if (listBox1.Items.Count > 0)
                listBox1.SetSelected(0, true);
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
        const string BadgeLine2 = "Congratulations! You earned the ";

        private void ReadChatLogFile()
        {
            string selection = $"{listBox1.SelectedItem}";
            if (string.IsNullOrEmpty(selection))
            {
                MessageBox.Show("No Selection!");
                return;
            }

            LogFileItem lfi = LogFileItem.List.Single(a => a.CombinedName == selection);


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

                ProcessContent(content, lfi);

            }
        }

        private void ProcessContent(string content, LogFileItem lfi)
        {

            BadgeManager.Load(lfi);
            DateTime startDateTime = lfi.StartDate;

            string[] lines = content.Split('\r');


            var badgesEntries = lines.Where(a => a.EndsWith(BadgeLine) || a.Contains(BadgeLine2));

            foreach (string badgeEntry in badgesEntries)
            {
                //"2019-12-28 12:37:03 " -- cut first 20
                string date = badgeEntry.Substring(0, 20);
                DateTime lineDate = DateTime.Parse(date);
                if (lineDate > startDateTime)
                {
                    string line = badgeEntry.Substring(20, badgeEntry.Length - 20);
                    if (line.EndsWith(BadgeLine))
                    {
                        line = line.Replace(BadgeLine, string.Empty);
                        BadgeManager.Add(new BadgeItem { Name = line, Selected = true });
                    }
                    if (line.Contains(BadgeLine2))
                    {
                        line = line.Replace(BadgeLine2, string.Empty);
                        line = line.Replace("badge.", string.Empty);
                        line = line.Trim();
                        BadgeManager.Add(new BadgeItem { Name = line, Selected = true });
                    }
                }
            }



            BadgeManager.Save();

            MessageBox.Show("Chat log file detection completed!");


            //LoadUI();

            LoadMatches();
        }

        private void bShowMatches_Click(object sender, EventArgs e)
        {
            LoadMatches();
        }


        private void LoadMatches()
        {
            string selection = $"{listBox1.SelectedItem}";
            if (string.IsNullOrEmpty(selection))
            {
                MessageBox.Show("No Selection!");
                return;
            }

            LogFileItem lfi = LogFileItem.List.Single(a => a.CombinedName == selection);


            if (lfi == null)
            {
                MessageBox.Show("lfi is null"); ;
                return;

            }


            this.Hide();
            frmShowMatches frm = new frmShowMatches(lfi);

            frm.Focus();
            frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmHelpCoHFolder frm = new frmHelpCoHFolder();

            frm.Focus();
            frm.ShowDialog();
            //this.Show();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
