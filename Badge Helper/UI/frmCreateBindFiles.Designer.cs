namespace Badge_Helper
{
    partial class frmCreateBindFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateBindFiles));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblDone2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(19, 69);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(347, 20);
            this.txtFolder.TabIndex = 4;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate bind files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.Location = new System.Drawing.Point(372, 67);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(38, 30);
            this.bBrowse.TabIndex = 6;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a folder as the destination folder for the bind files.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "It is recommanded to use a folder with a short path like  \"C:\\temp\\coh\"";
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(453, 127);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(108, 18);
            this.lblProcessing.TabIndex = 9;
            this.lblProcessing.Text = "Processing...";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.ForeColor = System.Drawing.Color.Blue;
            this.lblDone.Location = new System.Drawing.Point(16, 131);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(378, 13);
            this.lblDone.TabIndex = 10;
            this.lblDone.Text = "Use the command abobe in game, then the ctrl+m bind to cycle to all the files...";
            // 
            // lblDone2
            // 
            this.lblDone2.AutoSize = true;
            this.lblDone2.ForeColor = System.Drawing.Color.Blue;
            this.lblDone2.Location = new System.Drawing.Point(16, 145);
            this.lblDone2.Name = "lblDone2";
            this.lblDone2.Size = new System.Drawing.Size(367, 13);
            this.lblDone2.TabIndex = 11;
            this.lblDone2.Text = "Go back the the main menu and open the \"Badge Detection\" window first!!!!";
            // 
            // frmCreateBindFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 167);
            this.Controls.Add(this.lblDone2);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateBindFiles";
            this.Text = "Create Bind Files";
            this.Load += new System.EventHandler(this.frmCreateBindFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblDone2;
    }
}