using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            bool Exit = false;
            while (!Exit)
            {
                Application.DoEvents(); //Now if you call "form.Show()" your form won´t be frozen
                Controller.GameController game = new Controller.GameController();
                game.StartGame();
            }
        }
    }
}
