using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void PlayerNext_Click(object sender, System.EventArgs e);

    public class GameEvents
    {
        private int AmoutPlayers;
        public event PlayerNext_Click PlayerNext;

        public GameEvents()
        {

        }
        public void OnPlayerNext(PlayerNextEventArgs e)
        {

        }

    }
}
