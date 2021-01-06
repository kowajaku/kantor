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
    public partial class Zamiana_PLN_obca : Form
    {
        Form poprzednie;
        double kurs = -1;
        double marza = 0.04;
        string kod_wybranej_waluty = "USD";
        public Zamiana_PLN_obca(Form poprzednie)
        {
            this.poprzednie = poprzednie;
            InitializeComponent();
            tB_kwota.Text = "0,00";
            cB_waluty.Items.Add("USD");
            cB_waluty.Items.Add("EUR");
            cB_waluty.Items.Add("GBP");
            cB_waluty.Items.Add("CHF");
            cB_waluty.SelectedIndex = 0;
            
        }

        private void Zamiana_PLN_obca_FormClosing(object sender, FormClosingEventArgs e)
        {
            poprzednie.Show();
        }

        private void bt_zamien_Click(object sender, EventArgs e)
        {
            tB_kwota.Text = tB_kwota.Text.Replace(".", ",");
            double kwota_PLN = Convert.ToDouble(tB_kwota.Text);
            double kwota_wyplaty = kwota_PLN / kurs;
            kwota_wyplaty= Math.Round(kwota_wyplaty, 2);
            if (walidacja_kwoty(kwota_wyplaty)==true)
            {
                Stan_walut_kantoru stan = MySQL_Load_base.pobierz_stan_kantoru();
                if(stan==null)
                {
                    MessageBox.Show("Problem z baza");
                    return;
                }
                stan.PLN += kwota_PLN;
                if(kod_wybranej_waluty=="USD")
                {
                    stan.USD -= kwota_wyplaty;
                }
                else if (kod_wybranej_waluty == "EUR")
                {
                    stan.EUR -= kwota_wyplaty;
                }
                else if(kod_wybranej_waluty == "GBP")
                {
                    stan.GBP -= kwota_wyplaty;
                }
                else if (kod_wybranej_waluty == "CHF")
                {
                    stan.CHF -= kwota_wyplaty;
                }
                //MessageBox.Show(MySQL_Load_base.aktualizacja_stanu_walut_kantoru(stan));
                if (MySQL_Load_base.aktualizacja_stanu_walut_kantoru(stan) == true)
                {
                    MessageBox.Show("Pomysleni wymieniono walute!!!");
                }
                else
                {
                    MessageBox.Show("Problem z baza!!!");
                }
                this.Close();
            }

        }

        private bool walidacja_kwoty(double kwota)
        {
            Stan_walut_kantoru stan = MySQL_Load_base.pobierz_stan_kantoru();
           
            if (kod_wybranej_waluty == "USD")
            {
                if (kwota > stan.USD)
                {
                    MessageBox.Show("Brak wystarczających środków");
                    return false;
                }
            }
            else if (kod_wybranej_waluty == "EUR")
            {
                if (kwota > stan.EUR)
                {
                    MessageBox.Show("Brak wystarczających środków");
                    return false;
                }
            }
            else if (kod_wybranej_waluty == "GBP")
            {
                if (kwota > stan.GBP)
                {
                    MessageBox.Show("Brak wystarczających środków");
                    return false;
                }
            }
            else if (kod_wybranej_waluty == "CHF")
            {
                if (kwota > stan.CHF)
                {
                    MessageBox.Show("Brak wystarczających środków");
                    return false;
                }
            }

            return true;
        }

        private void cB_waluty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kod_waluty= cB_waluty.Items[cB_waluty.SelectedIndex].ToString();
            API_NPB nbp_obj = new API_NPB();
            kurs = nbp_obj.Pobierz_kurs_waluty(kod_waluty);
            kod_wybranej_waluty = kod_waluty;
            if(kurs==-1)
            {
                label3.Text = "Kurs: -----------";
            }
            else
            {
                kurs= Math.Round(kurs, 2);
                kurs += marza;
                label3.Text= "Kurs: "+kurs.ToString();
            }
        }
    }
}
