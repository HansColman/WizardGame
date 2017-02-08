using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    public interface INamesView
    {
        void SetController(GameController controller);
        string NamePlayer1 { set; }
        string NamePlayer2 { set; }
        string NamePlayer3 { set; }
        string NamePlayer4 { set; }
        string NamePlayer5 { set; }
        string NamePlayer6 { set; }
    }
}
