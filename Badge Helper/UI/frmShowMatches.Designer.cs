namespace Badge_Helper
{
    partial class frmShowMatches
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowMatches));
            this.tabControlGrp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalBadgeCount = new System.Windows.Forms.Label();
            this.tabControlGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlGrp
            // 
            this.tabControlGrp.Controls.Add(this.tabPage1);
            this.tabControlGrp.Controls.Add(this.tabPage2);
            this.tabControlGrp.Location = new System.Drawing.Point(13, 97);
            this.tabControlGrp.Name = "tabControlGrp";
            this.tabControlGrp.SelectedIndex = 0;
            this.tabControlGrp.Size = new System.Drawing.Size(989, 399);
            this.tabControlGrp.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabBadges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalBadgeCount
            // 
            this.lblTotalBadgeCount.AutoSize = true;
            this.lblTotalBadgeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBadgeCount.Location = new System.Drawing.Point(625, 43);
            this.lblTotalBadgeCount.Name = "lblTotalBadgeCount";
            this.lblTotalBadgeCount.Size = new System.Drawing.Size(35, 25);
            this.lblTotalBadgeCount.TabIndex = 14;
            this.lblTotalBadgeCount.Text = "- -";
            // 
            // frmShowMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 593);
            this.Controls.Add(this.lblTotalBadgeCount);
            this.Controls.Add(this.tabControlGrp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowMatches";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.frmShowMatches_Load);
            this.tabControlGrp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGrp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalBadgeCount;
    }
}