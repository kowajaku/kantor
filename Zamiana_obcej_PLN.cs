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
    public partial class Zamiana_obcej_PLN : Form
    {
        Form poprzedni;
        public Zamiana_obcej_PLN(Form poprzedni)
        {
            this.poprzedni = poprzedni;
            InitializeComponent();
            cB_waluty.Items.Add("USD");
            cB_waluty.Items.Add("EUR");
            cB_waluty.Items.Add("GBP");
            cB_waluty.Items.Add("CHF");
            cB_waluty.SelectedIndex = 0;
        }

        private void Zamiana_obcej_PLN_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.poprzedni.Show();
        }

        private void bt_zamien_Click(object sender, EventArgs e)
        {

        }
    }
}
