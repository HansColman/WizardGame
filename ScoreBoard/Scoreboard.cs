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
        private int _requested, _recieved;
        private int score;
        
        public bool Changed { get; set; }

        public Scoreboard()
        {
            calc = new Calculator();
            Changed = true;
        }
        public int? Received
        {
            set
            {
                if (value != null)
                    _recieved = (int)value;
                else
                    throw new ArgumentNullException("Received value cannot be null");
            }
        }
        public string PlayersName { get; set; }
        public int? Requested
        {
            set
            {
                if (value != null)
                    _requested = (int)value;
                else
                    throw new ArgumentNullException("Requested value cannot be null");
            }
        }
        public int Score
        {
            get
            {
                if (Changed)
                    return score += calc.calculate(_requested, _recieved); 
                return score;
            }
        }
    }
}
