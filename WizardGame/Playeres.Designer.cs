using System;
using System.Windows.Forms;

namespace WizardGame
{
    partial class Players
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private RadioButton rBtn3;
        private RadioButton rBtn4;
        private RadioButton rBTn5;
        private RadioButton rBtn6;
        private Button btnNext;

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
            this.label1 = new Label();
            this.rBtn3 = new RadioButton();
            this.rBtn4 = new RadioButton();
            this.rBTn5 = new RadioButton();
            this.rBtn6 = new RadioButton();
            this.btnNext = new Button();
            this.SuspendLayout();
            // 
            // lblPlay2Rec
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "lblPlay2Rec";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the amount of players";
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(30, 60);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(37, 21);
            this.rBtn3.TabIndex = 1;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "3";
            this.rBtn3.UseVisualStyleBackColor = true;
            this.rBtn3.CheckedChanged += new System.EventHandler(this.rBtn3_CheckedChanged);
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.Location = new System.Drawing.Point(73, 60);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(37, 21);
            this.rBtn4.TabIndex = 2;
            this.rBtn4.TabStop = true;
            this.rBtn4.Text = "4";
            this.rBtn4.UseVisualStyleBackColor = true;
            this.rBtn4.CheckedChanged += new System.EventHandler(this.rBtn4_CheckedChanged);
            // 
            // rBTn5
            // 
            this.rBTn5.AutoSize = true;
            this.rBTn5.Location = new System.Drawing.Point(116, 60);
            this.rBTn5.Name = "rBTn5";
            this.rBTn5.Size = new System.Drawing.Size(37, 21);
            this.rBTn5.TabIndex = 3;
            this.rBTn5.TabStop = true;
            this.rBTn5.Text = "5";
            this.rBTn5.UseVisualStyleBackColor = true;
            this.rBTn5.CheckedChanged += new System.EventHandler(this.rBTn5_CheckedChanged);
            // 
            // rBtn6
            // 
            this.rBtn6.AutoSize = true;
            this.rBtn6.Location = new System.Drawing.Point(159, 60);
            this.rBtn6.Name = "rBtn6";
            this.rBtn6.Size = new System.Drawing.Size(37, 21);
            this.rBtn6.TabIndex = 4;
            this.rBtn6.TabStop = true;
            this.rBtn6.Text = "6";
            this.rBtn6.UseVisualStyleBackColor = true;
            this.rBtn6.CheckedChanged += new System.EventHandler(this.rBtn6_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(73, 102);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 152);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rBtn6);
            this.Controls.Add(this.rBTn5);
            this.Controls.Add(this.rBtn4);
            this.Controls.Add(this.rBtn3);
            this.Controls.Add(this.label1);
            this.Name = "Players";
            this.Text = "Welcome";
            this.FormClosed += new FormClosedEventHandler(this.Round1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private void Round1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

