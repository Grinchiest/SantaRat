﻿namespace Server.Forms
{
    partial class FormDownloadFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDownloadFile));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelsize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downloaad:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelsize
            // 
            this.labelsize.AutoSize = true;
            this.labelsize.Location = new System.Drawing.Point(69, 54);
            this.labelsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsize.Name = "labelsize";
            this.labelsize.Size = new System.Drawing.Size(17, 12);
            this.labelsize.TabIndex = 0;
            this.labelsize.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "File:";
            // 
            // labelfile
            // 
            this.labelfile.AutoSize = true;
            this.labelfile.Location = new System.Drawing.Point(69, 23);
            this.labelfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfile.Name = "labelfile";
            this.labelfile.Size = new System.Drawing.Size(17, 12);
            this.labelfile.TabIndex = 0;
            this.labelfile.Text = "..";
            // 
            // FormDownloadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 91);
            this.Controls.Add(this.labelfile);
            this.Controls.Add(this.labelsize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDownloadFile";
            this.Text = "Download";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SocketDownload_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelsize;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelfile;
        public System.Windows.Forms.Label label1;
    }
}