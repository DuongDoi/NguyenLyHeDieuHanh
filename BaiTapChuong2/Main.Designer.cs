﻿namespace BaiTapChuong2
{
    partial class Main
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
            this.SJFbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SJFbtn
            // 
            this.SJFbtn.Location = new System.Drawing.Point(12, 233);
            this.SJFbtn.Name = "SJFbtn";
            this.SJFbtn.Size = new System.Drawing.Size(276, 68);
            this.SJFbtn.TabIndex = 0;
            this.SJFbtn.Text = "SJF";
            this.SJFbtn.UseVisualStyleBackColor = true;
            this.SJFbtn.Click += new System.EventHandler(this.SJFbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "FCFS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 68);
            this.button2.TabIndex = 0;
            this.button2.Text = "SRTN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 68);
            this.button3.TabIndex = 0;
            this.button3.Text = "RR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 68);
            this.button4.TabIndex = 0;
            this.button4.Text = "Process and Thread";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 398);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SJFbtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 437);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 437);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập chương 2 - nhóm 9";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SJFbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

