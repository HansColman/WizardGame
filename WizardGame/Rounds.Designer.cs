using System;
using System.Windows.Forms;

namespace WizardGame
{
    partial class Rounds
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNextRound;
        //Play1 Rec
        private Label lblPlay1Rec;
        //Play1 Req
        private Label lblPlay1Req;
        //Play2 Rec
        private Label lblPlay2Rec;
        //play2 Req 
        private Label lblPlay2Req;
        //Play3 Rec
        private Label lblPlay3Rec;
        //play3 Req 
        private Label lblPlay3Req;
        //play4 Rec
        private Label lblPlay4Rec;
        //play4 Req
        private Label lblPlay4Req;
        //play5 rec
        private Label lblPlay5Rec;
        //play5 req
        private Label lblPlay5Req;
        //Play6 Rec
        private Label lblPlay6Rec;
        //Play6 Req
        private Label lblPlay6Req;

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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.lblPlay1Rec = new Label();
            this.lblPlay1Req = new Label();
            this.lblPlay2Rec = new Label();
            this.lblPlay2Req = new Label();
            this.lblPlay3Rec = new Label();
            this.lblPlay3Req = new Label();
            this.btnNextRound = new Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 19;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1800, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPlay1Rec
            // 
            this.lblPlay1Rec.Location = new System.Drawing.Point(0, 0);
            this.lblPlay1Rec.Name = "lblPlay1Rec";
            this.lblPlay1Rec.Size = new System.Drawing.Size(100, 23);
            this.lblPlay1Rec.TabIndex = 0;
            // 
            // lblPlay1Req
            // 
            this.lblPlay1Req.Location = new System.Drawing.Point(0, 0);
            this.lblPlay1Req.Name = "lblPlay1Req";
            this.lblPlay1Req.Size = new System.Drawing.Size(100, 23);
            this.lblPlay1Req.TabIndex = 0;
           // 
            // lblPlay2Rec
            // 
            this.lblPlay2Rec.Location = new System.Drawing.Point(0, 0);
            this.lblPlay2Rec.Name = "lblPlay2Rec";
            this.lblPlay2Rec.Size = new System.Drawing.Size(100, 23);
            this.lblPlay2Rec.TabIndex = 0;
            // 
            // lblPlay2Req
            // 
            this.lblPlay2Req.Location = new System.Drawing.Point(0, 0);
            this.lblPlay2Req.Name = "lblPlay2Req";
            this.lblPlay2Req.Size = new System.Drawing.Size(100, 23);
            this.lblPlay2Req.TabIndex = 0;
            // 
            // lblPlay3Rec
            // 
            this.lblPlay3Rec.Location = new System.Drawing.Point(0, 0);
            this.lblPlay3Rec.Name = "lblPlay3Rec";
            this.lblPlay3Rec.Size = new System.Drawing.Size(100, 23);
            this.lblPlay3Rec.TabIndex = 0; 
            // lblPlay3Req
            // 
            this.lblPlay3Req.Location = new System.Drawing.Point(0, 0);
            this.lblPlay3Req.Name = "lblPlay3Req";
            this.lblPlay3Req.Size = new System.Drawing.Size(100, 23);
            this.lblPlay3Req.TabIndex = 0;
            // 
            // btnNextRound
            // 
            this.btnNextRound.Location = new System.Drawing.Point(485, 270);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(75, 23);
            this.btnNextRound.TabIndex = 1;
            this.btnNextRound.Text = "Round 2";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Click += new System.EventHandler(this.OnNextRoundClick);
            // 
            // Round1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 320);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Rounds";
            this.Text = "Round1";
            this.FormClosed += new FormClosedEventHandler(this.Round1_FormClosed);
            this.ResumeLayout(false);

        }
        #endregion

        
    }
}