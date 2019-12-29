using System;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowMatches frm = new frmShowMatches();
            frm.Focus();
            frm.ShowDialog();
            this.Show();
        }

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
    }
}
