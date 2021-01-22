using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace OtelOtomasyonu
{
    class Odalar
    {
        public string buyPerson { get; set; }
        public string state { get; set; }
        public string buttonAdi { get; set; }

        Database database = new Database();

        public void odaDeger(string odaAdi,string durum) // metod tanımı
        {
            if (database.baglanti.State == System.Data.ConnectionState.Open)
            {
                database.baglanti.Close();
            }

            try
            {
                database.baglanti.Open();
                OracleCommand odalariAl = new OracleCommand("SELECT * FROM ODALAR where OdaAdi=:OdaAdi and OdaDurumu=:OdaDurumu", database.baglanti);
                odalariAl.Parameters.Add(new OracleParameter(":OdaAdi",odaAdi));
                odalariAl.Parameters.Add(new OracleParameter(":OdaDurumu", durum));
                OracleDataReader odalari_Oku = odalariAl.ExecuteReader();

                if (odalari_Oku.Read())
                {
                    buyPerson = odalari_Oku["OdaSahibi"].ToString();
                    state = odalari_Oku["OdaDurumu"].ToString();
                    buttonAdi = odalari_Oku["buttonName"].ToString();

                }

                odalariAl.Dispose();
                odalari_Oku.Close();

            }
            catch(Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(""+hata);
            }
            finally
            {
                database.baglanti.Close();
            }
        }


        public void oda_kayitAl(string odaAdi, string odaSahibi, string odaDurumu, string buttonName)
        {
            if (database.baglanti.State == System.Data.ConnectionState.Open)
            {
                database.baglanti.Close(); // bağlantı açıksa bağlantıyı kapat
            }
            try
            {
                database.baglanti.Open(); // bağlantıyı aç
                OracleCommand oda_kayitEkle = new OracleCommand("INSERT INTO ODALAR (OdaAdi,OdaSahibi,OdaDurumu,buttonName) VALUES(:OdaAdi,:OdaSahibi,:OdaDurumu,:buttonName)",
                database.baglanti); // insert ifadesi yazılacak
                oda_kayitEkle.Parameters.Add(new OracleParameter(":OdaAdi", odaAdi)); // parametreler üzerinde işlem yapılacak
                oda_kayitEkle.Parameters.Add(new OracleParameter(":OdaSahibi", odaSahibi));
                oda_kayitEkle.Parameters.Add(new OracleParameter(":OdaDurumu", odaDurumu));
                oda_kayitEkle.Parameters.Add(new OracleParameter(":buttonName", buttonName));
                oda_kayitEkle.ExecuteNonQuery(); // eklemeleri yap
                oda_kayitEkle.Dispose(); // ram bellekten boşaltmaya yarar.

               
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }

            finally
            {
                database.baglanti.Close(); // bağlantıyı kapat
            }

        }
    }
}
