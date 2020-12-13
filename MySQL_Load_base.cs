using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kantor
{
    class MySQL_Load_base
    {
        private static string connectionString = @"server=localhost;userid=root;password=;database=kantor_baza";
        public static int zaloguj(string login,string haslo)
        {
            //1 - sukces
            //0 - blad loginu lub hasla
            //-1 - problem z baza
            try
            {
                string sql = String.Format("SELECT COUNT(*) FROM uzytkownicy WHERE `login`='{0}' and `Haslo`='{1}';",login, haslo);
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                if (cmd.ExecuteScalar().ToString() == "0")
                {
                    con.Close();
                    return 0;
                }
                else
                {
                    con.Close();
                    return 1;
                }

            }
            catch (Exception e)
            {
              
                return -1;
            }
        }



        public static int Admin(string login, string haslo)
        {
            //1 - Admin
            //0 - zwykly
            //-1 - problem z baza
            try
            {
                string sql = String.Format("SELECT Uprawnienia FROM uzytkownicy WHERE `login`='{0}' and `Haslo`='{1}';", login, haslo);
              
                var con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                if (cmd.ExecuteScalar().ToString() == "0")
                {
                    con.Close();
                    return 1;
                }
                else
                {
                    con.Close();
                    return 0;
                }

            }
            catch (Exception e)
            {
                return -1;
            }     
        }


        public static int pobierz_ID(string login, string haslo)
        {
            int ID_uzytkonika = -1;
            try
            {
                string sql = String.Format("SELECT ID FROM uzytkownicy WHERE `login`='{0}' and `Haslo`='{1}';", login, haslo);
                
                var con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                ID_uzytkonika = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                return ID_uzytkonika;
            }
            catch (Exception e)
            {
                return ID_uzytkonika;
            }
        }

    }
}
