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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            button3.Visible = false;
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmShowMatches frm = new frmShowMatches();
        //    frm.Focus();
        //    frm.ShowDialog();
        //    this.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCreateBindFiles frm = new frmCreateBindFiles();
            frm.Focus();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmDetection
            this.Hide();
            frmDetection frm = new frmDetection();
            frm.Focus();
            frm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coh_content_db_homecoming.ImportManager.Import();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string bindPath = BindFileConfig.Instance.FolderPath;


            List<RawDataItem> rawDataList = BadgeRawData.Read();

            List<RawBadgeItem> badges = new List<RawBadgeItem>();

            foreach (RawDataItem rdi in rawDataList)
                badges.AddRange(rdi.Badges);

            int max = badges.Max(a => a.SetTitleID);
            //foreach (RawBadgeItem b in badges.OrderBy(a=> a.SetTitleID))
            List<int> missingList = new List<int>();
            StringBuilder sb = new StringBuilder();
            int fileCpt = 0;
            for (int i = 1; i <= max; i++)
            {
                if (!badges.Exists(a => a.SetTitleID == i))
                {
                    missingList.Add(i);
                    sb.AppendLine(i.ToString());
                    //--

                    string iterString = $"set_title {i}$$l {i}$$";
                    string currentFilePath = Path.Combine(bindPath, $"bind{fileCpt}.txt");
                    string newFilePath = Path.Combine(bindPath, $"bind{fileCpt + 1}.txt");
                    string content = $"ctrl+m \"{iterString}bind_Load_file {newFilePath}\"";

                    File.WriteAllText(currentFilePath, content);
                    fileCpt++;



                }
            }
            

        }
    }
}
