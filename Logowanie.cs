using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantor
{
    public partial class Logowanie : Form
    {
        public bool czy_zalogowano { get; private set; }
        public bool czy_admin { get; private set; }
        public Logowanie()
        {
            InitializeComponent();
        }
        private bool zaloguj()
        {

            return true;
        }
        private void bt_logowanie_Click(object sender, EventArgs e)
        {
            if (zaloguj()==true)
            {
                czy_zalogowano = true;
                Close();
            }
              
        }
    }
}
