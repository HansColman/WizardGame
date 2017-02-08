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
        IPlayersView _view;

        private Service.GameService service;
        public GameController()
        {
            service = new Service.GameService();
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
        public void PlayRound1()
        {

        }

        

    }
}
