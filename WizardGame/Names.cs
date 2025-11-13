using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardGame
{
    public partial class Names : Form, INamesView
    {
        private GameController _controller;
        private Rounds round1;
        public Names()
        {
            round1 = new Rounds();
            InitializeComponent();
        }
        public void SetController(GameController controller)
        {
            _controller = controller;
            switch (controller.AmountPlayers)
            {
                case 3:
                    play3Players();
                    break;
                case 4:
                    play4Players();
                    break;
                case 5:
                    play5Players();
                    break;
                case 6:
                    play6Players();
                    break;
            }
        }
        public string NamePlayer1
        {
            get
            {
                return _controller.NamePlayer1;
            }
            set
            {
                _controller.NamePlayer1 = value;
            }
        }
        public string NamePlayer2
        {
            get
            {
                return _controller.NamePlayer2;
            }
            set
            {
                _controller.NamePlayer2 = value;
            }
        }
        public string NamePlayer3
        {
            get
            {
                return _controller.NamePlayer3;
            }
            set
            {
                _controller.NamePlayer3 = value;
            }
        }
        public string NamePlayer4
        {
            get
            {
                return _controller.NamePlayer4;
            }
            set
            {
                _controller.NamePlayer4 = value;
            }
        }
        public string NamePlayer5
        {
            get
            {
                return _controller.NamePlayer5;
            }
            set
            {
                _controller.NamePlayer5 = value;
            }
        }
        public string NamePlayer6
        {
            get
            {
                return _controller.NamePlayer6;
            }
            set
            {
                _controller.NamePlayer6 = value;
            }
        }
        public void play3Players()
        {
            // lblPlayer1
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(3, 12);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1:";
            // lblPlayer2
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(3, 40);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2:";
            // lblPlayer3
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(3, 68);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer3.TabIndex = 2;
            this.lblPlayer3.Text = "Player 3:";
            // txtPlayer1
            this.txtPlayer1.Location = new System.Drawing.Point(74, 12);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer1.TabIndex = 3;
            this.txtPlayer1.LostFocus += new System.EventHandler(this.OnTxt1LostFocus);
            // txtPlayer2
            this.txtPlayer2.Location = new System.Drawing.Point(74, 40);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer2.TabIndex = 4;
            this.txtPlayer2.LostFocus += new System.EventHandler(this.OnTxt2LostFocus);
            // txtPlayer3
            this.txtPlayer3.Location = new System.Drawing.Point(74, 68);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer3.TabIndex = 5;
            this.txtPlayer3.LostFocus += new System.EventHandler(this.OnTxt3LostFocus);
            //btnNext
            btnNext.TabIndex = 6;
        }
        public void play4Players()
        {
            play3Players();
            this.pnl1.Controls.Add(this.lblPlayer4);
            this.pnl1.Controls.Add(this.txtPlayer4);
            // lblPlayer4
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(3, 96);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer4.TabIndex = 6;
            this.lblPlayer4.Text = "Player 4:";
            // txtPlayer4
            this.txtPlayer4.Location = new System.Drawing.Point(74, 96);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer4.TabIndex = 7;
            this.txtPlayer4.LostFocus += new System.EventHandler(this.OnTxt4LostFocus);
            //btnNext
            btnNext.TabIndex = 8;
        }
        public void play5Players()
        {
            play4Players();
            this.pnl1.Controls.Add(this.lblPlayer5);
            this.pnl1.Controls.Add(this.txtPlayer5);
            // lblPlayer5
            this.lblPlayer5.AutoSize = true;
            this.lblPlayer5.Location = new System.Drawing.Point(3, 124);
            this.lblPlayer5.Name = "lblPlayer5";
            this.lblPlayer5.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer5.TabIndex = 8;
            this.lblPlayer5.Text = "Player 5:";
            // txtPlayer5
            this.txtPlayer5.Location = new System.Drawing.Point(74, 124);
            this.txtPlayer5.Name = "txtPlayer5";
            this.txtPlayer5.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer5.TabIndex = 9;
            this.txtPlayer5.LostFocus += new System.EventHandler(this.OnTxt5LostFocus);
            //btnNext
            btnNext.TabIndex = 10;
        }
        public void play6Players()
        {
            play5Players();
            this.pnl1.Controls.Add(this.lblPlayer6);
            this.pnl1.Controls.Add(this.txtPlayer6);
            // lblPlayer6
            this.lblPlayer6.AutoSize = true;
            this.lblPlayer6.Location = new System.Drawing.Point(3, 152);
            this.lblPlayer6.Name = "lblPlayer6";
            this.lblPlayer6.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer6.TabIndex = 10;
            this.lblPlayer6.Text = "Player 6:";
            // txtPlayer6
            this.txtPlayer6.Location = new System.Drawing.Point(74, 152);
            this.txtPlayer6.Name = "txtPlayer6";
            this.txtPlayer6.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer6.TabIndex = 11;
            this.txtPlayer6.LostFocus += new System.EventHandler(this.OnTxt6LostFocus);
            //btnNext
            btnNext.TabIndex = 12;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (_controller.AmountPlayers)
            {
                case 3:
                    _controller.Play3Player(NamePlayer1, NamePlayer2, NamePlayer3);
                    break;
                case 4:
                    _controller.Play4Player(NamePlayer1, NamePlayer2, NamePlayer3, NamePlayer4);
                    break;
                case 5:
                    _controller.Play5Player(NamePlayer1, NamePlayer2, NamePlayer3, NamePlayer4, NamePlayer5);
                    break;
                case 6:
                    _controller.Play6Player(NamePlayer1, NamePlayer2, NamePlayer3, NamePlayer4, NamePlayer5, NamePlayer6);
                    break;
            }
            round1.SetController(_controller);
            round1.Show();
            this.Close();
        }
        private void OnTxt1LostFocus(object sender, EventArgs e)
        {
            NamePlayer1 = txtPlayer1.Text;
        }
        private void OnTxt2LostFocus(object sender, EventArgs e)
        {
            NamePlayer2 = this.txtPlayer2.Text;
        }
        private void OnTxt3LostFocus(object sender, EventArgs e)
        {
            NamePlayer3 = this.txtPlayer3.Text;
        }
        private void OnTxt4LostFocus(object sender, EventArgs e)
        {
            NamePlayer4 = this.txtPlayer4.Text;
        }
        private void OnTxt5LostFocus(object sender, EventArgs e)
        {
            NamePlayer5 = this.txtPlayer5.Text;
        }
        private void OnTxt6LostFocus(object sender, EventArgs e)
        {
            NamePlayer6 = this.txtPlayer6.Text;
        }
    }
}
