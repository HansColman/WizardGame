using System;
using System.Windows.Forms;

namespace WizardGame
{
    partial class Names
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel pnl1;
        private TextBox txtPlayer6;
        private Label lblPlayer6;
        private TextBox txtPlayer5;
        private Label lblPlayer5;
        private TextBox txtPlayer4;
        private Label lblPlayer4;
        private TextBox txtPlayer3;
        private Label lblPlayer3;
        private TextBox txtPlayer2;
        private Label lblPlayer2;
        private TextBox txtPlayer1;
        private Label lblPlayer1;
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
        private void InitializeComponent()
        {
            this.pnl1 = new Panel();
            this.btnNext = new Button();
            this.txtPlayer2 = new TextBox();
            this.lblPlayer2 = new Label();
            this.txtPlayer1 = new TextBox();
            this.lblPlayer1 = new Label();
            this.lblPlayer3 = new Label();
            this.txtPlayer3 = new TextBox();
            this.lblPlayer4 = new Label();
            this.txtPlayer4 = new TextBox();
            this.lblPlayer5 = new Label();
            this.txtPlayer5 = new TextBox();
            this.lblPlayer6 = new Label();
            this.txtPlayer6 = new TextBox();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // pnl1
            this.pnl1.Controls.Add(this.btnNext);
            this.pnl1.Controls.Add(this.txtPlayer2);
            this.pnl1.Controls.Add(this.lblPlayer2);
            this.pnl1.Controls.Add(this.txtPlayer1);
            this.pnl1.Controls.Add(this.lblPlayer1);
            this.pnl1.Controls.Add(this.lblPlayer3);
            this.pnl1.Controls.Add(this.txtPlayer3);
            this.pnl1.Location = new System.Drawing.Point(13, 13);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(542, 270);
            this.pnl1.TabIndex = 0;
            // btnNext
            this.btnNext.Location = new System.Drawing.Point(158, 227);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(172, 26);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // txtPlayer2
            this.txtPlayer2.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer2.TabIndex = 0;
            // lblPlayer2
            this.lblPlayer2.Location = new System.Drawing.Point(0, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer2.TabIndex = 1;
            // txtPlayer1
            this.txtPlayer1.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer1.TabIndex = 2;
            // lblPlayer1
            this.lblPlayer1.Location = new System.Drawing.Point(0, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer1.TabIndex = 3;
            //  lblPlayer3
            this.lblPlayer3.Location = new System.Drawing.Point(0, 0);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer3.TabIndex = 4;
            // txtPlayer3
            this.txtPlayer3.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer3.TabIndex = 5;
            // lblPlayer4
            this.lblPlayer4.Location = new System.Drawing.Point(0, 0);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer4.TabIndex = 0;
            // txtPlayer4
            this.txtPlayer4.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer4.TabIndex = 0;
            // lblPlayer5
            this.lblPlayer5.Location = new System.Drawing.Point(0, 0);
            this.lblPlayer5.Name = "lblPlayer5";
            this.lblPlayer5.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer5.TabIndex = 0;
            // txtPlayer5
            this.txtPlayer5.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer5.Name = "txtPlayer5";
            this.txtPlayer5.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer5.TabIndex = 0;
            //  lblPlayer6
            this.lblPlayer6.Location = new System.Drawing.Point(0, 0);
            this.lblPlayer6.Name = "lblPlayer6";
            this.lblPlayer6.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer6.TabIndex = 0;
            // txtPlayer6
            this.txtPlayer6.Location = new System.Drawing.Point(0, 0);
            this.txtPlayer6.Name = "txtPlayer6";
            this.txtPlayer6.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer6.TabIndex = 0;
            // Names
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 295);
            this.Controls.Add(this.pnl1);
            this.Name = "Names";
            this.Text = "Names";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        
    }
}