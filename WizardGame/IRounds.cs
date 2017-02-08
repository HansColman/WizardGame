using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    interface IRounds
    {
        void SetController(GameController controller);
        int Player1Recieved { set; }
        int Player1Requested { set; }
        int Player2Recieved { set; }
        int Player2Requested { set; }
        int Player3Recieved { set; }
        int Player3Requested { set; }
        int Player4Recieved { set; }
        int Player4Requested { set; }
        int Player5Recieved { set; }
        int Player5Requested { set; }
        int Player6Recieved { set; }
        int Player6Requested { set; }
    }
}
