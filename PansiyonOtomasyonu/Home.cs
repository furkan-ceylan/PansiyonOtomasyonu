using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace OtelOtomasyonu
{
    class Home
    {
        Database database = new Database();
        AnaEkran main = new AnaEkran();
        public string kullaniciAdi_tut { get; set; }
        public string kullaniciSifre_tut { get; set; }

        public string girisDurumu { get; set; }

        public void Login(string kullaniciAdi,string kullaniciSifre,DateTime tarih)
        {

            if(database.baglanti.State == System.Data.ConnectionState.Open)
            {
                database.baglanti.Close();
            }

            try
            {
                database.baglanti.Open();
                OracleCommand loginName = new OracleCommand("SELECT MusteriKad FROM MUSTERI WHERE MusteriKad=:kuladi",database.baglanti);
                loginName.Parameters.Add(new OracleParameter(":kulAdi", kullaniciAdi));
                OracleDataReader kulAdi_Oku = loginName.ExecuteReader();

                if (kulAdi_Oku.Read())
                {
                   
                    kullaniciAdi_tut = kulAdi_Oku["MusteriKad"].ToString();

                    OracleCommand loginPw = new OracleCommand("SELECT Musterisifre FROM MUSTERI WHERE Musterisifre=:sifre", database.baglanti);
                    loginPw.Parameters.Add(new OracleParameter(":sifre", kullaniciSifre));
                    OracleDataReader loginPw_Oku = loginPw.ExecuteReader();
                    if (loginPw_Oku.Read())
                    {

                        kullaniciSifre_tut = loginPw_Oku["Musterisifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut;
                        OracleCommand dateUpdate = new OracleCommand("update MUSTERI set tarih=:tarih where MusteriKad=:kuladi AND Musterisifre=:kulsifre", database.baglanti);
                        dateUpdate.Parameters.Add(new OracleParameter(":tarih", tarih));
                        dateUpdate.Parameters.Add(new OracleParameter(":kuladi", kullaniciAdi_tut));
                        dateUpdate.Parameters.Add(new OracleParameter(":kulsifre", kullaniciSifre_tut));
                        dateUpdate.ExecuteNonQuery();
                        dateUpdate.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ya da şifreyi yanlış girdin!", "Hata | Pansiyon otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loginName.Dispose();
                kulAdi_Oku.Close();
                database.baglanti.Close();
            }
            catch
            {

            }
            finally
            {
                database.baglanti.Close();
            }
        }

        public void LoginYonetici(string kullaniciAdi,string kullaniciSifre,DateTime tarih)
        {

            if (database.baglanti.State == System.Data.ConnectionState.Open)
            {
                database.baglanti.Close();
            }

            try
            {
                database.baglanti.Open();
                OracleCommand loginName = new OracleCommand("SELECT YoneticiKad FROM YONETICI WHERE YoneticiKad=:kuladi", database.baglanti);
                loginName.Parameters.Add(new OracleParameter(":kulAdi", kullaniciAdi));
                OracleDataReader kulAdi_Oku = loginName.ExecuteReader();

                if (kulAdi_Oku.Read())
                {

                    kullaniciAdi_tut = kulAdi_Oku["YoneticiKad"].ToString();
                    OracleCommand loginPw = new OracleCommand("SELECT Yoneticisifre FROM YONETICI WHERE Yoneticisifre=:sifre", database.baglanti);
                    loginPw.Parameters.Add(new OracleParameter(":sifre", kullaniciSifre));
                    OracleDataReader loginPw_Oku = loginPw.ExecuteReader();
                    if (loginPw_Oku.Read())
                    {

                        kullaniciSifre_tut = loginPw_Oku["Yoneticisifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut;
                        OracleCommand dateUpdate = new OracleCommand("update YONETICI set tarih=:tarih where YoneticiKad=:kuladi AND Yoneticisifre=:kulsifre", database.baglanti);
                        dateUpdate.Parameters.Add(new OracleParameter(":tarih", tarih));
                        dateUpdate.Parameters.Add(new OracleParameter(":kuladi", kullaniciAdi_tut));
                        dateUpdate.Parameters.Add(new OracleParameter(":kulsifre", kullaniciSifre_tut));
                        dateUpdate.ExecuteNonQuery();
                        dateUpdate.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ya da şifreyi yanlış girdin!", "Hata | Pansiyon otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loginName.Dispose();
                kulAdi_Oku.Close();
                database.baglanti.Close();
            }
            catch
            {

            }
            finally
            {
                database.baglanti.Close();
            }
        }
    }
}
