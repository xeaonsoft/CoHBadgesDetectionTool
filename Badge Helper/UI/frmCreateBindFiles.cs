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

namespace Badge_Helper
{
    public partial class frmCreateBindFiles : Form
    {
        public frmCreateBindFiles()
        {
            InitializeComponent();
            lblProcessing.Visible = false;
            lblDone.Visible = false;
            lblDone2.Visible = false;
        }
        private void frmCreateBindFiles_Load(object sender, EventArgs e)
        {
            LoadUI();
        }
        private void DeleteFiles(string bindPath)
        {

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
            button1.Visible = false;
            lblProcessing.Visible = true;
            this.Refresh();

            string bindPath = txtFolder.Text.Trim();
            if (string.IsNullOrEmpty(bindPath))
            {
                MessageBox.Show("Path is empty");
                return;
            }
            if (!Directory.Exists(bindPath))
            {
                MessageBox.Show("Folder does not exists");
                return;
            }
            DeleteFiles(bindPath);



            textBox2.Text = $"/bind_Load_file \"{Path.Combine(bindPath, $"bind0.txt")}\""; ;

            int fileCpt = 0;

            const int loopMax = 12;

            for (int i = 0; i < 2400; i += loopMax)
            {
                string currentFilePath = Path.Combine(bindPath, $"bind{fileCpt}.txt");
                string newFilePath = Path.Combine(bindPath, $"bind{fileCpt + 1}.txt");

                string iterString = string.Empty;
                for (int j = 0; j < loopMax; j++)
                {
                    iterString += $"set_title {i + j}$$";
                }

                string content = $"ctrl+m \"{iterString}bind_Load_file {newFilePath}\"";

                File.WriteAllText(currentFilePath, content);
                fileCpt++;
            }


            MessageBox.Show("Done!");
            button1.Visible = true;
            lblProcessing.Visible = false;
            lblDone.Visible = true;
            lblDone2.Visible = true;
            this.Refresh();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //txtFolder.Text = fbd.SelectedPath;
                BindFileConfig.Instance.FolderPath = fbd.SelectedPath;
                BindFileConfig.Instance.Save();
            }
            LoadUI();
        }


        private void LoadUI()
        {
            txtFolder.Text = BindFileConfig.Instance.FolderPath;
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
