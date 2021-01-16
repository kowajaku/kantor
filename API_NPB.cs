using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using Newtonsoft.Json;

namespace Kantor
{
    public class API_NPB
    {
        public string Pobierz_api_nbp(string date = "")
        {
            //funkcja ta przyjmuje  kod waluty jako string
            //następnie wykonuje zapytanie do API NBP
            //funkcja ta może zwrócić string zawierający JSON w przypadku
            //powodzenia lub pusty string w przypadku błedów
            if (date != "")
                date =date+ "/";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.nbp.pl/api/exchangerates/rates/a/"+date+"?format=json");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
            catch //(WebException ex)
            {
                return "";
            }
        }

        public class Root
        {
            //klasa Root potrzebna do parsowania JSON z API NBP
            public string table { get; set; }
            public string currency { get; set; }
            public string code { get; set; }
            public IList<Rates> rates { get; set; }
        }

        public class Rates
        {
            //klasa reprezentująca notowanie
            public string no { get; set; }
            public string effectiveDate { get; set; }
            public double mid { get; set; }
        }
        public double Pobierz_kurs_waluty(string kod_waluty="USD")
        {
            //funkca ta przyjmuje kod  waluty,  wywołuje funkjce 
            //Pobierz_api_nbp następnie parsuje otrzymany JSON
            //wprzypadku  pomyślnej zamiany zwracany jest kurs waluty
            //jeśli coś poszło nie tak to zwracana jestwartość-1
            
            String JsonText = Pobierz_api_nbp(kod_waluty);
            double kurs = 0;
            if (JsonText == "")
            {
                return -1;
            }
            else
            {
                try
                {
                    var tmp = JsonConvert.DeserializeObject<Root>(JsonText);
                    kurs = tmp.rates[0].mid;
                    return kurs;
                }
                catch(Exception e)
                {
                    return -1;
                }
            }
            return kurs;
        }
    }
}
