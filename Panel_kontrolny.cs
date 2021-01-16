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
        private int ID_zalogowany;
        public Panel_kontrolny(int  ID_zalogowany=-1,int czy_admin=0)
        {
            //konstruktor  panelu konstorlnego
            //w  praypadku zalogowania  jako  admin wyswietla  sie przycisk
            //podglad zaś w przypadku zalogowania  jako zwykły uzytkownik  nie
            this.ID_zalogowany=ID_zalogowany;
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
            //reakcja na klikniecie przycisku, tworzone  jest nowe
            //okno wymiany waluty PLN na  obca walute 
            Zamiana_PLN_obca PLN_obca = new Zamiana_PLN_obca(this,ID_zalogowany);
            PLN_obca.Show();
            this.Hide();
        }

        private void bt_zamina_obca_Click(object sender, EventArgs e)
        {
            //reakcja na klikniecie przycisku, tworzone  jest nowe
            //okno wymiany waluty obca walute na PLN
            Zamiana_obcej_PLN obca_PLN = new Zamiana_obcej_PLN(this,ID_zalogowany);
            obca_PLN.Show();
            this.Hide();
        }

        private void bt_podglad_Click(object sender, EventArgs e)
        {
            //reakcja na klikniecie przycisku, tworzone  jest nowe
            //okno podgladu tranzakcji, przycisk ten jest aktuwny tylko i wyłącznie
            //jeśli zalogowani jesteśmy jako administrator
            Podglad okno = new Podglad(this);
            okno.Show();
            this.Hide();
        }
    }
}
