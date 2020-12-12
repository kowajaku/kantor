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
    public partial class Panel_kontrolny : Form
    {
        public Panel_kontrolny(int czy_admin=0)
        {
            InitializeComponent();
            if (czy_admin == 1)
            {
                bt_podglad.Visible = true;
            }
            else 
            {
                bt_podglad.Visible = false;
            }
        }

        private void bt_zamina_PLN_Click(object sender, EventArgs e)
        {

        }

        private void bt_zamina_obca_Click(object sender, EventArgs e)
        {

        }

        private void bt_podglad_Click(object sender, EventArgs e)
        {

        }
    }
}
