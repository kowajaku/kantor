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
            
            textBox1.Text= "kubaKowal";
            textBox2.Text = "1234";
        }
        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
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
            string login = textBox1.Text;
            string haslo = CreateMD5(textBox2.Text);
            
            int war = MySQL_Load_base.zaloguj(login, haslo);
            if (war==1)
            {
                int admin= MySQL_Load_base.Admin(login, haslo);
                ID_uzytkonika = MySQL_Load_base.pobierz_ID(login, haslo);
                if(admin==-1 || ID_uzytkonika==-1)
                {
                    MessageBox.Show("Problem z polaczeniem z baza danych!!!");
                }
                else
                {
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
