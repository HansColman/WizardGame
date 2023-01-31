using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardGame
{
    public class GameController
    {
        private string _NamePlayer1,
            _NamePlayer2,
            _NamePlayer3,
            _NamePlayer4,
            _NamePlayer5,
            _NamePlayer6;
        private GameService service;
        public GameController(IPlayersView view)
        {
            view.SetController(this);
            service = new GameService();
        }
        public int AmountPlayers
        {
            get
            {
                return service.AmountOfPlayers;
            }
            set
            {
                try
                {
                    service.AmountOfPlayers = value;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public string NamePlayer1
        {
            get
            {
                return _NamePlayer1;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _NamePlayer1 = value;
                }
                else
                {
                    MessageBox.Show("Name Player1 Can be empty");
                }
            }
        }
        public string NamePlayer2
        {
            get
            {
                return _NamePlayer2;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _NamePlayer2 = value;
                }
                else
                {
                    MessageBox.Show("Name Player2 Can be empty");
                }
            }
        }
        public string NamePlayer3
        {
            get
            {
                return _NamePlayer3;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _NamePlayer3 = value;
                }
                else
                {
                    MessageBox.Show("Name Player3 Can be empty");
                }
            }
        }
        public string NamePlayer4
        {
            get
            {
                return _NamePlayer4;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _NamePlayer4 = value;
                }
                else
                {
                    MessageBox.Show("Name Player4 Can be empty");
                }
            }
        }
        public string NamePlayer5
        {
            get
            {
                return _NamePlayer5;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _NamePlayer5 = value;
                }
                else
                {
                    MessageBox.Show("Name Player5 Can be empty");
                }
            }
        }
        /// <summary>
        /// The Name of the 6th player
        /// </summary>
        public string NamePlayer6
        {
            get
            {
                return _NamePlayer6;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _NamePlayer6 = value;
                }
                else
                {
                    MessageBox.Show("Name Player6 Can be empty");
                }
            }
        }
        /// <summary>
        /// This function will be used when playing with 3 players
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="player3"></param>
        public void Play3Player(string player1, string player2, string player3)
        {
            try
            {
                service.Play3Players(player1, player2, player3);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// This function will be used when playing with 4 players
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="player3"></param>
        /// <param name="player4"></param>
        public void Play4Player(string player1, string player2, string player3, string player4)
        {
            try
            {
                service.Play4Players(player1, player2, player3,player4);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// This function will be used when playing with 5 players
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="player3"></param>
        /// <param name="player4"></param>
        /// <param name="player5"></param>
        public void Play5Player(string player1, string player2, string player3, string player4, string player5)
        {
            try
            {
                service.Play5Players(player1, player2, player3, player4, player5);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// This function will be used when playing with 6 players
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="player3"></param>
        /// <param name="player4"></param>
        /// <param name="player5"></param>
        /// <param name="player6"></param>
        public void Play6Player(string player1, string player2, string player3, string player4, string player5, string player6)
        {
            try
            {
                service.Play6Players(player1, player2, player3, player4, player5, player6);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public int SetPlayer1(int recieved,int requested, bool nextRound = false)
        {
            int result = service.SetResultPlayer1(recieved, requested, nextRound);
            return result;
        }
        public int SetPlayer2( int recieved, int requested, bool nextRaound = false)
        {
            int result = service.SetResultPlayer2(recieved, requested,nextRaound);
            return result;
        }
        public int SetPlayer3(int recieved, int requested, bool nextRaound = false)
        {
            int result= service.SetResultPlayer3(recieved, requested,nextRaound);
            return result;
        }
        public bool IsLastRound(int currentRound)
        {
            return service.IsThisTheLastRound(currentRound);
        }

        public int SetPlayer4(int recieved, int requested, bool nextRaound = false)
        {
            int result = service.SetResultPlayer4(recieved, requested, nextRaound);
            return result;
        }
        public int SetPlayer5(int recieved, int requested, bool nextRaound = false)
        {
            int result = service.SetResultPlayer5(recieved, requested, nextRaound);
            return result;
        }
        public int SetPlayer6(int recieved, int requested, bool nextRaound = false)
        {
            int result = service.SetResultPlayer6(recieved, requested, nextRaound);
            return result;
        }
    }
}
