namespace Badge_Helper
{
    partial class frmDetection
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bDetect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 95);
            this.listBox1.TabIndex = 7;
            // 
            // bBrowse
            // 
            this.bBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.Location = new System.Drawing.Point(368, 111);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(38, 30);
            this.bBrowse.TabIndex = 9;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(15, 113);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(347, 20);
            this.txtFolder.TabIndex = 8;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select the folder where CoH/Tequilla is installed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select an account from the list:";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.ForeColor = System.Drawing.Color.Blue;
            this.lblDone.Location = new System.Drawing.Point(12, 44);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(611, 13);
            this.lblDone.TabIndex = 12;
            this.lblDone.Text = "Open this window first, then use the bind files in game, only log chat entry pass" +
    " the date and time listed above will be considered.";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.ForeColor = System.Drawing.Color.Blue;
            this.lblDateTime.Location = new System.Drawing.Point(12, 22);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(34, 13);
            this.lblDateTime.TabIndex = 13;
            this.lblDateTime.Text = "-date-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(62, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Once you are done using the bind files in game, press the \"Detect\" button!";
            // 
            // bDetect
            // 
            this.bDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetect.Location = new System.Drawing.Point(433, 349);
            this.bDetect.Name = "bDetect";
            this.bDetect.Size = new System.Drawing.Size(208, 49);
            this.bDetect.TabIndex = 15;
            this.bDetect.Text = "Detect";
            this.bDetect.UseVisualStyleBackColor = true;
            this.bDetect.Click += new System.EventHandler(this.bDetect_Click);
            // 
            // frmDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDetect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "frmDetection";
            this.Text = "frmDetection";
            this.Load += new System.EventHandler(this.frmDetection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDetect;
    }
}