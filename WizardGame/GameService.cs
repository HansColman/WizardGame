using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    public class GameService
    {
        private ScoreBoard.Scoreboard[] scoreboards;
        private int _amountPlayers;
        public GameService()
        {
            scoreboards = new ScoreBoard.Scoreboard[6];
        }
        /// <summary>
        /// The amount of players
        /// </summary>
        public int AmountOfPlayers
        {
            get
            {
                return _amountPlayers;
            }
            set
            {
                if (value >= 3 || value <= 6)
                {
                    _amountPlayers = value;
                }
                else
                {
                    throw new Exception("The value can not be less than 3 or biger than 6");
                }
            }
        }
        /// <summary>
        /// This function will be used when playing with 3 players
        /// </summary>
        /// <param name="player1Name">The name of the first player</param>
        /// <param name="player2Name">The name of the second player</param>
        /// <param name="player3Name">The name of the third player</param>
        public void Play3Players(string player1Name, string player2Name, string player3Name)
        {
            scoreboards[0] = new ScoreBoard.Scoreboard
            {
                PlayersName = player1Name
            };
            scoreboards[1] = new ScoreBoard.Scoreboard
            {
                PlayersName = player2Name
            };
            scoreboards[2] = new ScoreBoard.Scoreboard
            {
                PlayersName = player3Name
            };
        }
        /// <summary>
        /// This function will be used when playing with 4 players
        /// </summary>
        /// <param name="player1Name">The name of the first player</param>
        /// <param name="player2Name">The name of the second player</param>
        /// <param name="player3Name">The name of the third player</param>
        /// <param name="player4Name"></param>
        public void Play4Players(string player1Name, string player2Name, string player3Name, string player4Name)
        {
            Play3Players(player1Name, player2Name, player3Name);
            scoreboards[3] = new ScoreBoard.Scoreboard
            {
                PlayersName = player4Name
            };
        }
        /// <summary>
        /// This function will be used when playing with 5 players
        /// </summary>
        /// <param name="player1Name">The name of the first player</param>
        /// <param name="player2Name">The name of the second player</param>
        /// <param name="player3Name">The name of the third player</param>
        /// <param name="player4Name">The name of the fourth player</param>
        /// <param name="player5Name">The name of the fifth player</param>
        public void Play5Players(string player1Name, string player2Name, string player3Name, string player4Name, string player5Name)
        {
            Play4Players(player1Name, player2Name, player3Name, player4Name);
            scoreboards[4] = new ScoreBoard.Scoreboard 
            { 
                PlayersName = player5Name 
            };
        }
        /// <summary>
        /// This function will be used when playing with 6 players
        /// </summary>
        /// <param name="player1Name">The name of the first player</param>
        /// <param name="player2Name">The name of the second player</param>
        /// <param name="player3Name">The name of the third player</param>
        /// <param name="player4Name">The name of the fourth player</param>
        /// <param name="player5Name">The name of the fifth player</param>
        /// <param name="player6Name">The name of the sixth player</param>
        public void Play6Players(string player1Name, string player2Name, string player3Name, string player4Name, string player5Name, string player6Name)
        {
            Play5Players(player1Name, player2Name, player3Name, player4Name, player5Name);
            scoreboards[5] = new ScoreBoard.Scoreboard 
            { 
                PlayersName = player6Name 
            };
        }
        /// <summary>
        /// This function will let you know if the curent round is the last round or not
        /// </summary>
        /// <param name="currentRound">The current round</param>
        /// <returns>Boolean</returns>
        public Boolean IsThisTheLastRound(int currentRound)
        {
            Boolean result = false;
            int rounds = 0;
            switch (_amountPlayers)
            {
                case 3:
                    rounds = 20;
                    break;
                case 4:
                    rounds = 15;
                    break;
                case 5:
                    rounds = 12;
                    break;
                case 6:
                    rounds = 10;
                    break;
            }
            if (currentRound == rounds)
            {
                result = true;
            }
            return result;
        }
        public int SetResultPlayer1(int recieved, int requested)
        {
            scoreboards[0].Requested = requested;
            scoreboards[0].Received= recieved;
            return scoreboards[0].Score;
        }
        public int SetResultPlayer2(int recieved, int requested)
        {
            scoreboards[1].Requested = requested;
            scoreboards[1].Received= recieved;
            return scoreboards[1].Score;
        }
        public int SetResultPlayer3(int recieced, int requested)
        {
            scoreboards[2].Requested = requested;
            scoreboards[2].Received= recieced;
            return scoreboards[2].Score;
        }
        public int SetResultPlayer4(int recieced, int requested)
        {
            scoreboards[3].Requested = requested;
            scoreboards[3].Received = recieced;
            return scoreboards[3].Score;
        }
        public int SetResultPlayer5(int recieced, int requested)
        {
            scoreboards[4].Requested = requested;
            scoreboards[4].Received = recieced;
            return scoreboards[4].Score;
        }
        public int SetResultPlayer6(int recieced, int requested)
        {
            scoreboards[5].Requested = requested;
            scoreboards[5].Received = recieced;
            return scoreboards[5].Score;
        }
    }
}
