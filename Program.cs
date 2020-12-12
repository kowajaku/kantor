using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logowanie logowanie = new Logowanie();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(logowanie);

            if (logowanie.czy_zalogowano)
            {
                // MainForm is defined elsewhere
                if (logowanie.czy_admin == true)
                {
                    Application.Run(new Panel_kontrolny(1));
                }
                else
                {
                    Application.Run(new Panel_kontrolny());
                }
            }
        }
    }
}
