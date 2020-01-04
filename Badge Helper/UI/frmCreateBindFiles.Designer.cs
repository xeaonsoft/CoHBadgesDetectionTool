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
            this.txtBind0 = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemsPerFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBind0
            // 
            this.txtBind0.Location = new System.Drawing.Point(16, 130);
            this.txtBind0.Name = "txtBind0";
            this.txtBind0.Size = new System.Drawing.Size(347, 20);
            this.txtBind0.TabIndex = 5;
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(16, 104);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(347, 20);
            this.txtFolder.TabIndex = 4;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate bind files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.Location = new System.Drawing.Point(372, 102);
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
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a folder as the destination folder for the bind files.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "It is recommanded to use a folder with a short path like  \"C:\\temp\\coh\"";
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(454, 153);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(108, 18);
            this.lblProcessing.TabIndex = 9;
            this.lblProcessing.Text = "Processing...";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.ForeColor = System.Drawing.Color.Blue;
            this.lblDone.Location = new System.Drawing.Point(16, 179);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(393, 13);
            this.lblDone.TabIndex = 10;
            this.lblDone.Text = "Use the command above in game, then the CTRL+M bind to cycle to all the files...";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(262, 282);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(147, 49);
            this.bClose.TabIndex = 19;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "You will have to use CTRL+M many times... up to when you see , the bind file not " +
    "found message, up to 200 times ish.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sadly there is not work around this process!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(321, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "(Unable to read in keybind file: C:/Temp/testcoh/bind200.txt)";
            // 
            // txtBind
            // 
            this.txtBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBind.ForeColor = System.Drawing.Color.Purple;
            this.txtBind.Location = new System.Drawing.Point(12, 55);
            this.txtBind.Name = "txtBind";
            this.txtBind.Size = new System.Drawing.Size(75, 26);
            this.txtBind.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bind:";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxValue.ForeColor = System.Drawing.Color.Purple;
            this.txtMaxValue.Location = new System.Drawing.Point(93, 55);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(53, 26);
            this.txtMaxValue.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Max Value:";
            // 
            // txtItemsPerFile
            // 
            this.txtItemsPerFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsPerFile.ForeColor = System.Drawing.Color.Purple;
            this.txtItemsPerFile.Location = new System.Drawing.Point(167, 55);
            this.txtItemsPerFile.Name = "txtItemsPerFile";
            this.txtItemsPerFile.Size = new System.Drawing.Size(53, 26);
            this.txtItemsPerFile.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Bind items per file:";
            // 
            // frmCreateBindFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 363);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItemsPerFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.txtBind0);
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

        private System.Windows.Forms.TextBox txtBind0;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemsPerFile;
        private System.Windows.Forms.Label label8;
    }
}