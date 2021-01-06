﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kantor
{
    public class MySQL_Load_base
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

        public static List<List<string>> pobierz_dane_podglad()
        {
            List<List<string>> dane = new List<List<string>>();
            string sql = "SELECT`tranzakcje`.Data,`tranzakcje`.Godzina," +
                "`typy`.`Opis`,`tranzakcje`.Ilosc_jednostek_wym," +
                "`tranzakcje`.ilosc_jednostek_po_wymianie," +
                "`uzytkownicy`.Imie,`uzytkownicy`.Nazwisko " +
                "FROM (`tranzakcje` JOIN `uzytkownicy` on " +
                "`tranzakcje`.`ID_uzytkownika`=`uzytkownicy`.`ID`) " +
                "JOIN `typy` ON `tranzakcje`.`Typ_operacji`=`typy`.`ID` ";
            
            try
            {
                var con = new MySqlConnection(connectionString);
                con.Open();
                
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        List<string> row = new List<string>();
                        row.Add(reader["Data"].ToString());
                        row.Add(reader["Godzina"].ToString());
                        row.Add(reader["Opis"].ToString());
                        row.Add(reader["Ilosc_jednostek_wym"].ToString());
                        row.Add(reader["ilosc_jednostek_po_wymianie"].ToString());
                        row.Add(reader["Imie"].ToString());
                        row.Add(reader["Nazwisko"].ToString());
                        dane.Add(row);
                    }
                }
                else
                {
                    //MessageBox.Show("Data not found");
                }
                con.Close();
                return dane;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static  Stan_walut_kantoru pobierz_stan_kantoru()
        {
            Stan_walut_kantoru aktulany = new Stan_walut_kantoru();
            string sql = "SELECT * FROM `stan_walut` Limit 1";
            try
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aktulany.PLN = Convert.ToDouble(reader["PLN"]);
                        aktulany.USD = Convert.ToDouble(reader["USD"]);
                        aktulany.EUR = Convert.ToDouble(reader["EUR"]);
                        aktulany.GBP = Convert.ToDouble(reader["GBP"]);
                        aktulany.CHF = Convert.ToDouble(reader["CHF"]);
                    }
                }
                else
                {
                    //MessageBox.Show("Data not found");
                }
                con.Close();
                return aktulany;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static bool aktualizacja_stanu_walut_kantoru(Stan_walut_kantoru stan)
        {
            //jak  cos  sie zepsuje false
            string sql = String.Format("UPDATE `stan_walut` SET `PLN`={0},`USD`={1},`EUR`={2},`GBP`={3},`CHF`={4};",
                stan.PLN.ToString().Replace(",","."),
                stan.USD.ToString().Replace(",", "."),
                stan.EUR.ToString().Replace(",", "."),
                stan.GBP.ToString().Replace(",", "."),
                stan.CHF.ToString().Replace(",", "."));
            MySqlConnection conn = null;
            MySqlTransaction tr = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                tr = conn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tr;

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                tr.Commit();

            }
            catch (MySqlException ex)
            {
                tr.Rollback();
                if (conn != null)
                    conn.Close();
                return false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return true;
        }

    }
}
