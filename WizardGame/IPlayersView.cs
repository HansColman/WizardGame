using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    public interface IPlayersView
    {
        void SetController(GameController controller);
        int AmountPlayers { get; set; }
    }
}
