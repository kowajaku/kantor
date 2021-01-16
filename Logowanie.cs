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
        public int ID_uzytkonika { get; private set; }
        public Logowanie()
        {
            InitializeComponent();
        }
        public string CreateMD5(string input)
        {
            //funkcja ta generuje z  stringa podanego  jako  argument
            //hash algorytmem MD5
            //następnie zwraca hash  jako string
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        
        private void bt_logowanie_Click(object sender, EventArgs e)
        {
            //metoda wywoływana w momencie kliknięcia przycisku zaloguj
            
            //pobbierane są warości pola login i hasło
            string login = textBox1.Text;
            string haslo = CreateMD5(textBox2.Text);
            
            //baza danych jest odpytywana czy istnieje uzytkownik
            //o podanymloginie  i hasle
            int war = MySQL_Load_base.zaloguj(login, haslo);
            //jeśli funkcja zwróci 1  oznacza ze  logowanie  jest możliwe
            if (war==1)
            {
                //sprawdzamy czy podany  uzytkownik jest administratorem
                int admin= MySQL_Load_base.Admin(login, haslo);
                //pobieramy id uzytkownika
                ID_uzytkonika = MySQL_Load_base.pobierz_ID(login, haslo);
                //jeśli która kolwiek z funkcji zwróciła -1 to  oznacza
                //że jest problem z połączeniem
                if(admin==-1 || ID_uzytkonika==-1)
                {
                    MessageBox.Show("Problem z polaczeniem z baza danych!!!");
                }
                else
                {
                    //jeśli przebiegło wszystko pomyślnie ustawiam globalne zmienne
                    if (admin == 1) czy_admin = true;
                    else czy_admin = false;

                    czy_zalogowano = true;
                    Close();
                }
                
            }
            else if(war==-1)
            {
                MessageBox.Show("Problem z polaczeniem z baza danych!!!");
            }
            else
            {
                MessageBox.Show("Bledne dane logowania!!!!");
            }
            
        }
    }
}
