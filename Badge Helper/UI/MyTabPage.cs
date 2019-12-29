using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badge_Helper
{
    public class MyTabPage : TabPage
    {
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;


        RawDataItem _rdi;
        public MyTabPage(RawDataItem rdi, TabControl parent)
        {
            _rdi = rdi;
            this.Name = rdi.Name;
            this.Text = rdi.Name;

            InitializeComponent();


            this.listBox1.Top = this.textBox1.Height;
            this.listBox1.Width = parent.Width - 4;
            this.listBox1.Height = parent.Height - 26 - this.textBox1.Height;
            this.listBox1.Items.Clear();

            this.listBox1.DrawItem += ListBox1_DrawItem;


            this.textBox1.KeyUp += TextBox1_KeyUp;




            DrawMe();

        }
        private void DrawMe()
        {
            string keyWord = textBox1.Text.Trim().ToLowerInvariant();

            //var dataList = rdi.Badges.OrderBy(a => a.Group).ThenBy(a => a.Name).ToList();

            List<RawBadgeItem> dataList = _rdi.Badges.ToList();
            List<RawBadgeItem> filteredList = dataList.ToList();
            if (!string.IsNullOrEmpty(keyWord))
            {
                filteredList = dataList.Where(a => a.Name.Trim().ToLowerInvariant().Contains(keyWord)).ToList();
            }

            this.listBox1.Items.Clear();
            foreach (RawBadgeItem bi in filteredList)
            {
                BadgeManager.DetermineIfSelected(bi);
                this.listBox1.Items.Add(bi);
            }
            this.listBox1.Refresh();

            

            var total = dataList.Count();
            var selectedCount = dataList.Count(a => a.Selected);

            label1.Text = $"{selectedCount} out of {total}";
            label1.Refresh();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DrawMe();
        }



        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // MyTabPage
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /*
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
             */
        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            RawBadgeItem bi = (RawBadgeItem)this.listBox1.Items[e.Index];


            if (bi.Selected)
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);


            e.Graphics.DrawRectangle(Pens.Gray, e.Bounds);

            e.Graphics.DrawString(bi.Name, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top);

            e.Graphics.DrawString(bi.Group, e.Font, Brushes.Black, e.Bounds.Left + 500, e.Bounds.Top);


        }
    }
}
