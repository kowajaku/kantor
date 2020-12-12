using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        private string CreateMD5(string input)
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
        private bool zaloguj()
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=kantor_baza";
                //string sql = String.Format("SELECT COUNT(*) FROM uzytkownicy WHERE `login`='{0}' and `Haslo`='{1}';",textBox1.Text, CreateMD5(textBox2.Text));
                string sql = "SELECT COUNT(*) FROM uzytkownicy WHERE `login`='kubaKowal' and `Haslo`='81dc9bdb52d04dc20036dbd8313ed055'";
                var con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //object result = cmd.ExecuteScalar();
                if (cmd.ExecuteScalar().ToString() =="0")
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Problem z polaczeniem z baza");
                return false;
            }
            return false;
        }

        private bool Admin()
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=kantor_baza";
                //string sql = String.Format("SELECT Uprawnienia FROM uzytkownicy WHERE `login`='{0}' and `Haslo`='{1}';", textBox1.Text, CreateMD5(textBox2.Text));
                string sql = "SELECT Uprawnienia FROM uzytkownicy WHERE `login`='kubaKowal' and `Haslo`='81dc9bdb52d04dc20036dbd8313ed055'";
                var con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //object result = cmd.ExecuteScalar();
                if (cmd.ExecuteScalar().ToString() == "0")
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Problem z polaczeniem z baza");
                return false;
            }
            return false;
        }

        private void pobierz_ID()
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=kantor_baza";
                //string sql = String.Format("SELECT ID FROM uzytkownicy WHERE `login`='{0}' and `Haslo`='{1}';", textBox1.Text, CreateMD5(textBox2.Text));
                string sql = "SELECT ID FROM uzytkownicy WHERE `login`='kubaKowal' and `Haslo`='81dc9bdb52d04dc20036dbd8313ed055'";
                var con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //object result = cmd.ExecuteScalar();
                ID_uzytkonika = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Problem z polaczeniem z baza");
                ID_uzytkonika = -1;
            }
        }
        private void bt_logowanie_Click(object sender, EventArgs e)
        {
            if (zaloguj()==true)
            {
                czy_admin = Admin();
                pobierz_ID();
                czy_zalogowano = true;
                Close();
            }
            else
            {
                MessageBox.Show("Bledne dane logowania!!!!");
            }
              
        }
    }
}
