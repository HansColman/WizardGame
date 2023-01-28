using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBoard
{
    public class Scoreboard
    {
        private Calculator calc;
        private int _requested;
        private int score;

        public Scoreboard()
        {
            calc = new Calculator();
        }
        public int Received
        {
            set {
                score += calc.calculate(_requested, value);
            }
        }
        public string PlayersName { get; set; }
        public int Requested {
            set
            {
                _requested = value;
            }
        }
        public int Score => score;
    }
}
