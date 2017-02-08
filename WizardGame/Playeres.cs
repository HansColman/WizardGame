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
    public partial class Players : Form, IPlayersView
    {
        private Names name;
        private GameController _controller;
        public Players()
        {
            name = new Names();
            InitializeComponent();
        }
        public void SetController(GameController controller)
        {
            _controller = controller;
        }
        public int AmountPlayers {
            get
            {
                return _controller.AmountPlayers;
            }
            set
            {
                _controller.AmountPlayers = value;
            }
        }
        private void rBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn3.Checked)
            {
                AmountPlayers = 3;
            }
        }

        private void rBtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn4.Checked)
            {
                AmountPlayers = 4;
            }
        }

        private void rBTn5_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTn5.Checked)
            {
                AmountPlayers = 5;
            }
        }

        private void rBtn6_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn6.Checked)
            {
                AmountPlayers = 6;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            name.SetController(_controller);
            name.Show();
            this.Hide();
        }
    }
}
