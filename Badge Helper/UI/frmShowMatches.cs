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
    public partial class frmShowMatches : Form
    {
        private LogFileItem _lfi;
        public frmShowMatches(LogFileItem lfi)
        {
            _lfi = lfi;
            InitializeComponent();
        }

        private void frmShowMatches_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        
        public void LoadUI()
        {
            BadgeManager.Load(_lfi);

            List<RawDataItem> rdiList = BadgeRawData.Read();



            //Verif(rdiList);



            tabControlGrp.TabPages.Clear();


            foreach (RawDataItem rdi in rdiList)
            {
                tabControlGrp.TabPages.Add(new MyTabPage(rdi, tabControlGrp));
            }

            int count = BadgeManager.List.Count(a => a.Selected);
            lblTotalBadgeCount.Text = $"Total Badges:{count}";

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Verif(List<RawDataItem> rdiList)
        //{
        //    List<RawBadgeItem> badges = new List<RawBadgeItem>();

        //    foreach (RawDataItem rdi in rdiList)
        //    {
        //        badges.AddRange(rdi.Badges);
        //    }

        //    foreach (var bi in BadgeManager.List)
        //    {
        //        var matches = BadgeManager.DetermineIfSelected(badges, bi);
        //        if (matches.Count == 0)
        //        {

        //        }
        //        if (matches.Count > 1)
        //        {

        //        }
        //    }

        //}

    }
}
