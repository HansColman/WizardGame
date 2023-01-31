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
    public partial class Rounds : Form, IRounds
    {
        private GameController _controller;
        private int _player1Recieved,
            _player1Requested,
            _player2Recieved,
            _player2Requested,
            _player3Recieved,
            _player3Requested,
            _player4Recieved,
            _player4Requested,
            _player5Recieved,
            _player5Requested,
            _player6Recieved,
            _player6Requested,
            currentRound,
            width = 0,
            y = 0;
        public Rounds()
        {
            currentRound = 1;
            InitializeComponent();
        }
        public void SetController(GameController _controller)
        {
            this._controller = _controller;
            switch (_controller.AmountPlayers)
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
        public int Player1Recieved
        {
            set
            {
                _player1Recieved = value;
                setResultPlayer1(currentRound);
            }
            get
            {
                return _player1Recieved;
            }
        }
        public int Player1Requested
        {
            set
            {
                _player1Requested = value;
            }
            get
            {
                return _player1Requested;
            }
        }
        public int Player2Recieved
        {
            set
            {
                _player2Recieved = value;
                setResultPlayer2(currentRound);
            }
            get
            {
                return _player2Recieved;
            }
        }
        public int Player2Requested
        {
            set
            {
                _player2Requested = value;
            }
            get
            {
                return _player2Requested;
            }
        }
        public int Player3Recieved
        {
            set
            {
                _player3Recieved = value;
                setResultPlayer3(currentRound);
            }
            get
            {
                return _player3Recieved;
            }
        }
        public int Player3Requested
        {
            set
            {
                _player3Requested = value;
            }
            get
            {
                return _player3Requested;
            }
        }
        public int Player4Recieved
        {
            set
            {
                _player4Recieved = value;
                setResultPlayer4(currentRound);
            }
            get
            {
                return _player4Recieved;
            }
        }
        public int Player4Requested
        {
            set
            {
                _player4Requested = value;
            }
            get
            {
                return _player4Requested;
            }
        }
        public int Player5Recieved
        {
            set
            {
                _player5Recieved = value;
                setResultPlayer5(currentRound);
            }
            get
            {
                return _player5Recieved;
            }
        }
        public int Player5Requested
        {
            set
            {
                _player5Requested = value;
            }
            get
            {
                return _player5Requested;
            }
        }
        public int Player6Recieved
        {
            set
            {
                _player6Recieved = value;
                setResultPlayer6(currentRound);
            }
            get
            {
                return _player6Recieved;
            }
        }
        public int Player6Requested
        {
            set
            {
                _player6Requested = value;
            }
            get
            {
                return _player6Requested;
            }
        }
        private void Round1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void OnRoundPlay1RecLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play1Round" + currentRound.ToString() + "Rec")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player1Recieved = int.Parse(((TextBox)ctr).Text);
                        }
                        
                    }
                }
            }
        }
        private void OnRoundPlay1ReqLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play1Round" + currentRound.ToString() + "Req")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player1Requested = int.Parse(((TextBox)ctr).Text);
                        }
                    }
                }
            }
        }
        private void OnRoundPlay2RecLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play2Round" + currentRound.ToString() + "Rec")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player2Recieved = int.Parse(((TextBox)ctr).Text);
                        }

                    }
                }
            }
        }
        private void OnRoundPlay2ReqLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play2Round" + currentRound.ToString() + "Req")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player2Requested = int.Parse(((TextBox)ctr).Text);
                        }
                    }
                }
            }
        }
        private void OnRoundPlay3RecLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play3Round" + currentRound.ToString() + "Rec")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player3Recieved = int.Parse(((TextBox)ctr).Text);
                        }

                    }
                }
            }
        }
        private void OnRoundPlay3ReqLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play3Round" + currentRound.ToString() + "Req")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player3Requested = int.Parse(((TextBox)ctr).Text);
                        }
                    }
                }
            }
        }
        private void OnRoundPlay4RecLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play4Round" + currentRound.ToString() + "Rec")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player4Recieved = int.Parse(((TextBox)ctr).Text);
                        }

                    }
                }
            }
        }
        private void OnRoundPlay4ReqLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play4Round" + currentRound.ToString() + "Req")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player4Requested = int.Parse(((TextBox)ctr).Text);
                        }
                    }
                }
            }
        }
        private void OnRoundPlay5RecLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play5Round" + currentRound.ToString() + "Rec")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player5Recieved = int.Parse(((TextBox)ctr).Text);
                        }

                    }
                }
            }
        }
        private void OnRoundPlay5ReqLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play5Round" + currentRound.ToString() + "Req")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player5Requested = int.Parse(((TextBox)ctr).Text);
                        }
                    }
                }
            }
        }
        private void OnRoundPlay6RecLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play6Round" + currentRound.ToString() + "Rec")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player6Recieved = int.Parse(((TextBox)ctr).Text);
                        }

                    }
                }
            }
        }
        private void OnRoundPlay6ReqLostFocus(object sender, EventArgs e)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play6Round" + currentRound.ToString() + "Req")
                    {
                        if (string.IsNullOrEmpty(ctr.Text))
                        {
                            ctr.Text = "0";
                        }
                        else
                        {
                            Player6Requested = int.Parse(((TextBox)ctr).Text);
                        }
                    }
                }
            }
        }
        private void play3Players()
        {
            Label lblRound = new Label();
            Label lblPlay1Res = new Label();
            Label lblPlay2Res = new Label();
            Label lblPlay3Res = new Label();
            TextBox txtPlay1RoundReq = new TextBox();
            TextBox txtPlay1RoundRec = new TextBox();
            TextBox txtPlay1RoundRes = new TextBox();
            TextBox txtPlay2RoundReq = new TextBox();
            TextBox txtPlay2RoundRec = new TextBox();
            TextBox txtPlay2RoundRes = new TextBox();
            TextBox txtPlay3RoundReq = new TextBox();
            TextBox txtPlay3RoundRec = new TextBox();
            TextBox txtPlay3RoundRes = new TextBox();
            this.tableLayoutPanel1.Controls.Add(lblRound, 0, 1);
            //PLayer1 Req
            this.tableLayoutPanel1.Controls.Add(this.lblPlay1Req, 1, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay1RoundReq, 1, 1);
            //Player1 Rec
            this.tableLayoutPanel1.Controls.Add(this.lblPlay1Rec, 2, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay1RoundRec, 2, 1);
            // Player 1 Result
            this.tableLayoutPanel1.Controls.Add(lblPlay1Res, 3, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay1RoundRes, 3, 1);
            //PLay2 Req
            this.tableLayoutPanel1.Controls.Add(this.lblPlay2Req, 4, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay2RoundReq, 4, 1);
            //Play2 Rec
            this.tableLayoutPanel1.Controls.Add(this.lblPlay2Rec, 5, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay2RoundRec, 5, 1);
            // Player2 Result
            this.tableLayoutPanel1.Controls.Add(lblPlay2Res, 6, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay2RoundRes, 6, 1);
            //Play3 Req
            this.tableLayoutPanel1.Controls.Add(this.lblPlay3Req, 7, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay3RoundReq, 7, 1);
            //Play3 Rec
            this.tableLayoutPanel1.Controls.Add(this.lblPlay3Rec, 8, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay3RoundRec, 8, 1);
            // Player3 Result
            this.tableLayoutPanel1.Controls.Add(lblPlay3Res, 9, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay3RoundRes, 9, 1);
            //Lbl Round
            lblRound.AutoSize = true;
            lblRound.Location = new System.Drawing.Point(95, 0);
            lblRound.Size = new System.Drawing.Size(67, 34);
            lblRound.TabIndex = 3;
            lblRound.Text = "Round: "+currentRound.ToString();
            //lblPlay1Rec
            this.lblPlay1Rec.AutoSize = true;
            this.lblPlay1Rec.Location = new System.Drawing.Point(279, 0);
            this.lblPlay1Rec.Name = "lblPlay4Rec";
            this.lblPlay1Rec.Size = new System.Drawing.Size(67, 34);
            this.lblPlay1Rec.TabIndex = 5;
            this.lblPlay1Rec.Text = _controller.NamePlayer1 + ": Received";
            //Play1RoundRec
            txtPlay1RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay1RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay1RoundRec.Name = "Play1Round" + currentRound.ToString() + "Rec";
            txtPlay1RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay1RecLostFocus);
            //lblPlay1Req
            this.lblPlay1Req.AutoSize = true;
            this.lblPlay1Req.Location = new System.Drawing.Point(279, 0);
            this.lblPlay1Req.Name = "lblPlay1Req";
            this.lblPlay1Req.Size = new System.Drawing.Size(67, 34);
            this.lblPlay1Req.TabIndex = 5;
            this.lblPlay1Req.Text = _controller.NamePlayer1 + ": Requested";
            //Play1RoundReq
            txtPlay1RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay1RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay1RoundReq.Name = "Play1Round" + currentRound.ToString() + "Req";
            txtPlay1RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay1ReqLostFocus);
            //lblPLayRes
            lblPlay1Res.AutoSize = true;
            lblPlay1Res.Location = new System.Drawing.Point(279, 0);
            lblPlay1Res.Name = "lblPlay1Res";
            lblPlay1Res.Size = new System.Drawing.Size(67, 34);
            lblPlay1Res.TabIndex = 5;
            lblPlay1Res.Text = _controller.NamePlayer1 + ": Result";
            //Play1RoundResult
            txtPlay1RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay1RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay1RoundRes.Name = "Play1Round" + currentRound.ToString() + "Res";
            txtPlay1RoundRes.Enabled = false;
            //lblPlay2Rec
            this.lblPlay2Rec.AutoSize = true;
            this.lblPlay2Rec.Location = new System.Drawing.Point(279, 0);
            this.lblPlay2Rec.Name = "lblPlay4Rec";
            this.lblPlay2Rec.Size = new System.Drawing.Size(67, 34);
            this.lblPlay2Rec.TabIndex = 5;
            this.lblPlay2Rec.Text = _controller.NamePlayer2 + ": Received";
            //Play2RoundRec
            txtPlay2RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay2RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay2RoundRec.Name = "Play2Round" + currentRound.ToString() + "Rec";
            txtPlay2RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay2RecLostFocus);
            //lblPlay2Req
            this.lblPlay2Req.AutoSize = true;
            this.lblPlay2Req.Location = new System.Drawing.Point(279, 0);
            this.lblPlay2Req.Name = "lblPlay4Rec";
            this.lblPlay2Req.Size = new System.Drawing.Size(67, 34);
            this.lblPlay2Req.TabIndex = 5;
            this.lblPlay2Req.Text = _controller.NamePlayer2 + ": Requested";
            //Play2RoundReq
            txtPlay2RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay2RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay2RoundReq.Name = "Play2Round" + currentRound.ToString() + "Req";
            txtPlay2RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay2ReqLostFocus);
            //lblPlay2Res
            lblPlay2Res.AutoSize = true;
            lblPlay2Res.Location = new System.Drawing.Point(279, 0);
            lblPlay2Res.Name = "lblPlay2Res";
            lblPlay2Res.Size = new System.Drawing.Size(67, 34);
            lblPlay2Res.TabIndex = 5;
            lblPlay2Res.Text = _controller.NamePlayer2 + ": Result";
            //Play2RoundResult
            txtPlay2RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay2RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay2RoundRes.Name = "Play2Round" + currentRound.ToString() + "Res";
            txtPlay2RoundRes.Enabled = false;
            //lblPlay3Rec
            this.lblPlay3Rec.AutoSize = true;
            this.lblPlay3Rec.Location = new System.Drawing.Point(279, 0);
            this.lblPlay3Rec.Name = "lblPlay4Rec";
            this.lblPlay3Rec.Size = new System.Drawing.Size(67, 34);
            this.lblPlay3Rec.TabIndex = 5;
            this.lblPlay3Rec.Text = _controller.NamePlayer3 + ": Received";
            //Play3RoundRec
            txtPlay3RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay3RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay3RoundRec.Name = "Play3Round" + currentRound.ToString() + "Rec";
            txtPlay3RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay3RecLostFocus);
            //lblPlay3Req
            this.lblPlay3Req.AutoSize = true;
            this.lblPlay3Req.Location = new System.Drawing.Point(279, 0);
            this.lblPlay3Req.Name = "lblPlay4Rec";
            this.lblPlay3Req.Size = new System.Drawing.Size(67, 34);
            this.lblPlay3Req.TabIndex = 5;
            this.lblPlay3Req.Text = _controller.NamePlayer3 + ": Requested";
            //Play3RoundReq
            txtPlay3RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay3RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay3RoundReq.Name = "Play3Round" + currentRound.ToString() + "Req";
            txtPlay3RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay3ReqLostFocus);
            //lblPlay3Res
            lblPlay3Res.AutoSize = true;
            lblPlay3Res.Location = new System.Drawing.Point(279, 0);
            lblPlay3Res.Name = "lblPlay3Res";
            lblPlay3Res.Size = new System.Drawing.Size(67, 34);
            lblPlay3Res.TabIndex = 5;
            lblPlay3Res.Text = _controller.NamePlayer3 + ": Result";
            //Play3RoundResult
            txtPlay3RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay3RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay3RoundRes.Name = "Play3Round" + currentRound.ToString() + "Res";
            txtPlay3RoundRes.Enabled = false;
            this.ClientSize = new Size(3000, 380);
        }
        private void play4Players()
        {
            play3Players();
            lblPlay4Req = new Label();
            TextBox txtPlay4RoundReq = new TextBox();
            TextBox txtPlay4RoundRec = new TextBox();
            TextBox txtPlay4RoundRes = new TextBox();
            lblPlay4Rec = new Label();
            Label lblPlay4Res = new Label();
            //Play4 Req
            this.tableLayoutPanel1.Controls.Add(this.lblPlay4Req, 10, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay4RoundReq, 10, 1);
            //PLay4 Rec
            this.tableLayoutPanel1.Controls.Add(this.lblPlay4Rec, 11, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay4RoundRec, 11, 1);
            //Play4 Result
            this.tableLayoutPanel1.Controls.Add(lblPlay4Res, 12, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay4RoundRes, 12, 1);
            //lblPlay4Req
            this.lblPlay4Req.AutoSize = true;
            this.lblPlay4Req.Location = new System.Drawing.Point(279, 0);
            this.lblPlay4Req.Name = "lblPlay4Rec";
            this.lblPlay4Req.Size = new System.Drawing.Size(67, 34);
            this.lblPlay4Req.TabIndex = 5;
            this.lblPlay4Req.Text = _controller.NamePlayer4 + ": Requested";
            //txtPlay4RoundReq
            txtPlay4RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay4RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay4RoundReq.Name = "Play4Round" + currentRound.ToString() + "Req";
            txtPlay4RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay4ReqLostFocus);
            //LblPlay4Rec
            this.lblPlay4Rec.AutoSize = true;
            this.lblPlay4Rec.Location = new System.Drawing.Point(279, 0);
            this.lblPlay4Rec.Name = "lblPlay4Rec";
            this.lblPlay4Rec.Size = new System.Drawing.Size(67, 34);
            this.lblPlay4Rec.TabIndex = 5;
            this.lblPlay4Rec.Text = _controller.NamePlayer4 + ": Received";
            //txtPlay4RoundRec
            txtPlay4RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay4RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay4RoundRec.Name = "Play4Round" + currentRound.ToString() + "Rec";
            txtPlay4RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay4RecLostFocus);
            //lblPlay4Res
            lblPlay4Res.AutoSize = true;
            lblPlay4Res.Location = new System.Drawing.Point(279, 0);
            lblPlay4Res.Name = "lblPlay4Res";
            lblPlay4Res.Size = new System.Drawing.Size(67, 34);
            lblPlay4Res.TabIndex = 5;
            lblPlay4Res.Text = _controller.NamePlayer4 + ": Result";
            //txtPlay4RoundRes
            txtPlay4RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay4RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay4RoundRes.Name = "Play4Round" + currentRound.ToString() + "Res";
            txtPlay4RoundRes.Enabled = false;
        }
        private void play5Players()
        {
            play4Players();
            this.lblPlay5Rec = new Label();
            this.lblPlay5Req = new Label();
            Label lblPlay5Res = new Label();
            TextBox txtPlay5RoundReq = new TextBox();
            TextBox txtPlay5RoundRec = new TextBox();
            TextBox txtPlay5RoundRes = new TextBox();
            //Play5 Req
            this.tableLayoutPanel1.Controls.Add(this.lblPlay5Req, 13, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay5RoundReq, 13, 1);
            //PLay5 Rec
            this.tableLayoutPanel1.Controls.Add(this.lblPlay5Rec, 14, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay5RoundRec, 14, 1);
            //Play5 Result
            this.tableLayoutPanel1.Controls.Add(lblPlay5Res, 15, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay5RoundRes, 15, 1);
            //lblPlay5Req
            this.lblPlay5Req.AutoSize = true;
            this.lblPlay5Req.Location = new System.Drawing.Point(279, 0);
            this.lblPlay5Req.Name = "lblPlay5Rec";
            this.lblPlay5Req.Size = new System.Drawing.Size(67, 34);
            this.lblPlay5Req.TabIndex = 5;
            this.lblPlay5Req.Text = _controller.NamePlayer5 + ": Requested";
            //txtPlay5RoundReq
            txtPlay5RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay5RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay5RoundReq.Name = "Play5Round" + currentRound.ToString() + "Req";
            txtPlay5RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay5ReqLostFocus);
            //LblPlay5Rec
            this.lblPlay5Rec.AutoSize = true;
            this.lblPlay5Rec.Location = new System.Drawing.Point(279, 0);
            this.lblPlay5Rec.Name = "lblPlay5Rec";
            this.lblPlay5Rec.Size = new System.Drawing.Size(67, 34);
            this.lblPlay5Rec.TabIndex = 5;
            this.lblPlay5Rec.Text = _controller.NamePlayer5 + ": Received";
            //txtPlay5RoundRec
            txtPlay5RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay5RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay5RoundRec.Name = "Play5Round" + currentRound.ToString() + "Rec";
            txtPlay5RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay5RecLostFocus);
            //lblPlay5Res
            lblPlay5Res.AutoSize = true;
            lblPlay5Res.Location = new System.Drawing.Point(279, 0);
            lblPlay5Res.Name = "lblPlay5Res";
            lblPlay5Res.Size = new System.Drawing.Size(67, 34);
            lblPlay5Res.TabIndex = 5;
            lblPlay5Res.Text = _controller.NamePlayer5 + ": Result";
            //txtPlay5RoundRes
            txtPlay5RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay5RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay5RoundRes.Name = "Play5Round" + currentRound.ToString() + "Res";
            txtPlay5RoundRes.Enabled = false;
        }
        private void play6Players()
        {
            play5Players();
            lblPlay6Rec = new Label();
            lblPlay6Req = new Label();
            Label lblPlay6Res = new Label();
            TextBox txtPlay6RoundReq = new TextBox();
            TextBox txtPlay6RoundRec = new TextBox();
            TextBox txtPlay6RoundRes = new TextBox();
            //Play6 Req
            this.tableLayoutPanel1.Controls.Add(this.lblPlay6Req, 16, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay6RoundReq, 16, 1);
            //PLay6 Rec
            this.tableLayoutPanel1.Controls.Add(this.lblPlay6Rec, 17, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay6RoundRec, 17, 1);
            //Play6 Result
            this.tableLayoutPanel1.Controls.Add(lblPlay6Res, 18, 0);
            this.tableLayoutPanel1.Controls.Add(txtPlay6RoundRes, 18, 1);
            //lblPlay6Req
            this.lblPlay6Req.AutoSize = true;
            this.lblPlay6Req.Location = new System.Drawing.Point(279, 0);
            this.lblPlay6Req.Name = "lblPlay6Rec";
            this.lblPlay6Req.Size = new System.Drawing.Size(67, 34);
            this.lblPlay6Req.TabIndex = 5;
            this.lblPlay6Req.Text = _controller.NamePlayer6 + ": Requested";
            //txtPlay6RoundReq
            txtPlay6RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay6RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay6RoundReq.Name = "Play6Round" + currentRound.ToString() + "Req";
            txtPlay6RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay6ReqLostFocus);
            //LblPlay6Rec
            this.lblPlay6Rec.AutoSize = true;
            this.lblPlay6Rec.Location = new System.Drawing.Point(279, 0);
            this.lblPlay6Rec.Name = "lblPlay6Rec";
            this.lblPlay6Rec.Size = new System.Drawing.Size(67, 34);
            this.lblPlay6Rec.TabIndex = 5;
            this.lblPlay6Rec.Text = _controller.NamePlayer6 + ": Received";
            //txtPlay6RoundRec
            txtPlay6RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay6RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay6RoundRec.Name = "Play6Round" + currentRound.ToString() + "Rec";
            txtPlay6RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay6RecLostFocus);
            //lblPlay6Res
            lblPlay6Res.AutoSize = true;
            lblPlay6Res.Location = new System.Drawing.Point(279, 0);
            lblPlay6Res.Name = "lblPlay6Res";
            lblPlay6Res.Size = new System.Drawing.Size(67, 34);
            lblPlay6Res.TabIndex = 5;
            lblPlay6Res.Text = _controller.NamePlayer6 + ": Result";
            //txtPlay6RoundRes
            txtPlay6RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay6RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay6RoundRes.Name = "Play6Round" + currentRound.ToString() + "Res";
            txtPlay6RoundRes.Enabled = false;
        }
        private void OnNextRoundClick(object sender, EventArgs e)
        {
            switch (_controller.AmountPlayers)
            {
                case 3:
                    setResultPlayer1(currentRound, true);
                    setResultPlayer2(currentRound);
                    setResultPlayer3(currentRound);
                    break;
                case 4:
                    setResultPlayer1(currentRound);
                    setResultPlayer2(currentRound);
                    setResultPlayer3(currentRound);
                    setResultPlayer4(currentRound);
                    break;
                case 5:
                    setResultPlayer1(currentRound);
                    setResultPlayer2(currentRound);
                    setResultPlayer3(currentRound);
                    setResultPlayer4(currentRound);
                    setResultPlayer5(currentRound);
                    break;
                case 6:
                    setResultPlayer1(currentRound);
                    setResultPlayer2(currentRound);
                    setResultPlayer3(currentRound);
                    setResultPlayer4(currentRound);
                    setResultPlayer5(currentRound);
                    setResultPlayer6(currentRound);
                    break;

            }
            if (_controller.IsLastRound(currentRound))
            {
                this.btnNextRound.Enabled = false;
                this.btnNextRound.Text = "End of Game";
            }
            else
            {
                currentRound++;
                setNextRound();
            }
        }
        private void setNextRound()
        {
            this.tableLayoutPanel1.RowCount = currentRound + 1;
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //size = 70 for 2 rows +1
            //this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 90);
            int row = currentRound + 1;
            switch (_controller.AmountPlayers)
            {
                case 3:
                    set3Players(row);
                    break;
                case 4:
                    set4Players(row);
                    break;
                case 5:
                    set5Players(row);
                    break;
                case 6:
                    set6Players(row);
                    break;
            }
            
            if (currentRound == 6)
            {
                btnNextRound.Size = new Size(85, 23);
                y += 270 + 20;
                btnNextRound.Location = new Point(485, y);
                width += 380;
                this.ClientSize = new Size(3000, width);
            }
            else if (currentRound >= 9)
            {
                y += 25;
                btnNextRound.Location = new Point(485, y);
                width += 25;
                this.ClientSize = new Size(3000, width);
            }
            if (_controller.IsLastRound(currentRound))
            {
                this.btnNextRound.Enabled = false;
                this.btnNextRound.Text = "End of Game";
            }
            else
            {
                this.btnNextRound.Text = "Round " + this.tableLayoutPanel1.RowCount.ToString();
            }
            this.Text = "Round " + this.currentRound.ToString(); 
        }
        private void set3Players(int row)
        {
            Label lblRound = new Label();
            TextBox txtPlay1RoundReq = new TextBox();
            TextBox txtPlay1RoundRec = new TextBox();
            TextBox txtPlay1RoundRes = new TextBox();
            TextBox txtPlay2RoundReq = new TextBox();
            TextBox txtPlay2RoundRec = new TextBox();
            TextBox txtPlay2RoundRes = new TextBox();
            TextBox txtPlay3RoundReq = new TextBox();
            TextBox txtPlay3RoundRec = new TextBox();
            TextBox txtPlay3RoundRes = new TextBox();
            this.tableLayoutPanel1.Controls.Add(lblRound, 0, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay1RoundReq, 1, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay1RoundRec, 2, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay1RoundRes, 3, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay2RoundReq, 4, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay2RoundRec, 5, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay2RoundRes, 6, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay3RoundReq, 7, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay3RoundRec, 8, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay3RoundRes, 9, row);
            //Lbl Round
            lblRound.AutoSize = true;
            lblRound.Location = new System.Drawing.Point(95, 0);
            lblRound.Size = new System.Drawing.Size(67, 34);
            lblRound.TabIndex = 3;
            lblRound.Text = "Round: " + currentRound.ToString();
            //Play1RoundRec
            txtPlay1RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay1RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay1RoundRec.Name = "Play1Round" + currentRound.ToString() + "Rec";
            txtPlay1RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay1RecLostFocus);
            //Play1RoundReq
            txtPlay1RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay1RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay1RoundReq.Name = "Play1Round" + currentRound.ToString() + "Req";
            txtPlay1RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay1ReqLostFocus);
            //Play1RoundResult
            txtPlay1RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay1RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay1RoundRes.Name = "Play1Round" + currentRound.ToString() + "Res";
            txtPlay1RoundRes.Enabled = false;
            //Play2RoundRec
            txtPlay2RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay2RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay2RoundRec.Name = "Play2Round" + currentRound.ToString() + "Rec";
            txtPlay2RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay2RecLostFocus);
            //Play2RoundReq
            txtPlay2RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay2RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay2RoundReq.Name = "Play2Round" + currentRound.ToString() + "Req";
            txtPlay2RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay2ReqLostFocus);
            //Play2RoundResult
            txtPlay2RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay2RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay2RoundRes.Name = "Play2Round" + currentRound.ToString() + "Res";
            txtPlay2RoundRes.Enabled = false;
            //Play3RoundRec
            txtPlay3RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay3RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay3RoundRec.Name = "Play3Round" + currentRound.ToString() + "Rec";
            txtPlay3RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay3RecLostFocus);
            //Play3RoundReq
            txtPlay3RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay3RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay3RoundReq.Name = "Play3Round" + currentRound.ToString() + "Req";
            txtPlay3RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay3ReqLostFocus);
            //Play3RoundResult
            txtPlay3RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay3RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay3RoundRes.Name = "Play3Round" + currentRound.ToString() + "Res";
            txtPlay3RoundRes.Enabled = false;
        }
        private void set4Players(int row)
        {
            set3Players(row);
            TextBox txtPlay4RoundReq = new TextBox();
            TextBox txtPlay4RoundRec = new TextBox();
            TextBox txtPlay4RoundRes = new TextBox();
            this.tableLayoutPanel1.Controls.Add(txtPlay4RoundReq, 10, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay4RoundRec, 11, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay4RoundRes, 12, row);
            //txtPlay4RoundRec
            txtPlay4RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay4RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay4RoundRec.Name = "Play4Round" + currentRound.ToString() + "Rec";
            txtPlay4RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay4RecLostFocus);
            //txtPlay4RoundReq
            txtPlay4RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay4RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay4RoundReq.Name = "Play4Round" + currentRound.ToString() + "Req";
            txtPlay4RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay4ReqLostFocus);
            //txtPlay4RoundRes
            txtPlay4RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay4RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay4RoundRes.Name = "Play4Round" + currentRound.ToString() + "Res";
            txtPlay4RoundRes.Enabled = false;
        }
        private void set5Players(int row)
        {
            set4Players(row);
            TextBox txtPlay5RoundReq = new TextBox();
            TextBox txtPlay5RoundRec = new TextBox();
            TextBox txtPlay5RoundRes = new TextBox();
            this.tableLayoutPanel1.Controls.Add(txtPlay5RoundReq, 13, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay5RoundRec, 14, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay5RoundRes, 15, row);
            //txtPlay5RoundRec
            txtPlay5RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay5RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay5RoundRec.Name = "Play5Round" + currentRound.ToString() + "Rec";
            txtPlay5RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay5RecLostFocus);
            //txtPlay5RoundReq
            txtPlay5RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay5RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay5RoundReq.Name = "Play5Round" + currentRound.ToString() + "Req";
            txtPlay5RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay5ReqLostFocus);
            //txtPlay4RoundRes
            txtPlay5RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay5RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay5RoundRes.Name = "Play5Round" + currentRound.ToString() + "Res";
            txtPlay5RoundRes.Enabled = false;
        }
        private void set6Players(int row)
        {
            set5Players(row);
            TextBox txtPlay6RoundReq = new TextBox();
            TextBox txtPlay6RoundRec = new TextBox();
            TextBox txtPlay6RoundRes = new TextBox();
            this.tableLayoutPanel1.Controls.Add(txtPlay6RoundReq, 16, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay6RoundRec, 17, row);
            this.tableLayoutPanel1.Controls.Add(txtPlay6RoundRes, 18, row);
            //txtPlay6RoundRec
            txtPlay6RoundRec.Location = new System.Drawing.Point(95, 39);
            txtPlay6RoundRec.Size = new System.Drawing.Size(51, 22);
            txtPlay6RoundRec.Name = "Play6Round" + currentRound.ToString() + "Rec";
            txtPlay6RoundRec.LostFocus += new System.EventHandler(this.OnRoundPlay6RecLostFocus);
            //txtPlay6RoundReq
            txtPlay6RoundReq.Location = new System.Drawing.Point(95, 39);
            txtPlay6RoundReq.Size = new System.Drawing.Size(51, 22);
            txtPlay6RoundReq.Name = "Play6Round" + currentRound.ToString() + "Req";
            txtPlay6RoundReq.LostFocus += new System.EventHandler(this.OnRoundPlay6ReqLostFocus);
            //txtPlay6RoundRes
            txtPlay6RoundRes.Location = new System.Drawing.Point(95, 39);
            txtPlay6RoundRes.Size = new System.Drawing.Size(51, 22);
            txtPlay6RoundRes.Name = "Play6Round" + currentRound.ToString() + "Res";
            txtPlay6RoundRes.Enabled = false;
        }
        private void setResultPlayer1(int currentRound, bool nextRound = false)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play1Round" + currentRound.ToString() + "Res")
                    {
                        ctr.Text = _controller.SetPlayer1(Player1Recieved, Player1Requested, nextRound).ToString();
                    }
                }
            }
        }
        private void setResultPlayer2(int currentRound, bool nextRound = false)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play2Round" + currentRound.ToString() + "Res")
                    {
                        ctr.Text = _controller.SetPlayer2(Player2Recieved, Player2Requested,nextRound).ToString();
                    }
                }
            }
        }
        private void setResultPlayer3(int currentRound, bool nextRound = false)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play3Round" + currentRound.ToString() + "Res")
                    {
                        ctr.Text = _controller.SetPlayer3(Player3Recieved, Player3Requested,nextRound).ToString();
                    }
                }
            }
        }
        private void setResultPlayer4(int currentRound, bool nextRound = false)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play4Round" + currentRound.ToString() + "Res")
                    {
                        ctr.Text = _controller.SetPlayer4(Player4Recieved, Player4Requested, nextRound).ToString();
                    }
                }
            }
        }
        private void setResultPlayer5(int currentRound, bool nextRound = false)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play5Round" + currentRound.ToString() + "Res")
                    {
                        ctr.Text = _controller.SetPlayer5(Player5Recieved, Player5Requested, nextRound).ToString();
                    }
                }
            }
        }
        private void setResultPlayer6(int currentRound, bool nextRound = false)
        {
            foreach (Control ctr in this.tableLayoutPanel1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Name == "Play6Round" + currentRound.ToString() + "Res")
                    {
                        ctr.Text = _controller.SetPlayer6(Player6Recieved, Player6Requested, nextRound).ToString();
                    }
                }
            }
        }
    }
}
