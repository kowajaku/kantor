using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kantor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor.Tests
{
    [TestClass()]
    public class MySQL_Load_baseTests
    {
        [TestMethod()]
        public void zalogujTest_pusty()
        {
            if (MySQL_Load_base.zaloguj("", "") == 2)
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void zalogujTest_bledne_dane()
        {
            if (MySQL_Load_base.zaloguj("ala", "ma") == 2)
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void zalogujTest_poprawny_login_bez_hasla()
        {
            if (MySQL_Load_base.zaloguj("kubaKowal", "") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void zalogujTest_poprawny_dane()
        {
            if (MySQL_Load_base.zaloguj("kubaKowal", "81dc9bdb52d04dc20036dbd8313ed055") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AdminTest_puste_dane()
        {
            if (MySQL_Load_base.Admin("", "") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AdminTest_bledne_dane()
        {

            if (MySQL_Load_base.Admin("ala", "ma") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AdminTest_popranwy_login()
        {

            if (MySQL_Load_base.Admin("kubaKowal", "") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AdminTest_popranwy_login_bledny_hash()
        {
            if (MySQL_Load_base.Admin("kubaKowal", "81dc9bdb52d04dc20036dbd8313ed055") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void pobierz_IDTest_puste()
        {
            if (MySQL_Load_base.pobierz_ID("", "") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void pobierz_IDTest_bledne_dane()
        {
            if (MySQL_Load_base.pobierz_ID("ala", "ma") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void pobierz_IDTest_poprawny_login()
        {
            if (MySQL_Load_base.pobierz_ID("kubaKowal", "") == 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void pobierz_IDTest_poprawny_login_bledny_hash()
        {
            if (MySQL_Load_base.pobierz_ID("kubaKowal", "81dc9bdb52d04dc20036dbd8313ed055") == 2)
            {
                Assert.Fail();
            }
        }

        

        [TestMethod()]
        public void pobierz_dane_podgladTest()
        {
            List<List<string>> dane = new List<List<string>>();
            dane = MySQL_Load_base.pobierz_dane_podglad();
            if (dane == null)
            {
                Assert.Fail();
            }
        }


        [TestMethod()]
        public void hash_MD5_1()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("1234") != "81DC9BDB52D04DC20036DBD8313ED055")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_2()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("1234") == "81dc9bdb52d04dc20036dbd8313ed055")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_3()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("12345") == "827ccb0eea8a706c4c34a16891f84e7b")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_4()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("12345") == "827CCB0EEA8A706C4C34A16891f84E7B")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_5()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("ala ma kota") == "f9b788b7dd465b5195d6b326c3d771df")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_6()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("ala ma kota") == "81DC9BDB52D04DC20036DBD8313ED055")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_7()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("ala ma kota 1234") == "81DC9BDB52D04DC20036DBD8313ED055")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_8()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("ala ma kota kota i cotam") == "81DC9BDB52D04DC20036DBD8313ED055")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_9()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("ala ma kota") == "81DC9BDB52D000DC20036DBD8313ED055")
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void hash_MD5_10()
        {
            Logowanie tmp = new Logowanie();
            if (tmp.CreateMD5("qwerty") == "81D2020105020336DBD8313ED055")
            {
                Assert.Fail();
            }
        }

    }
}