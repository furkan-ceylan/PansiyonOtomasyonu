using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace OtelOtomasyonu
{
    class MusteriKayitOdaSecimi
    {
        public string kisi_Adi_Soyadi_Getir { get; set; }

        Database database = new Database(); // Database nesnesi oluşturuldu.

        public static void odaKayitAl(string odaAdi, string odaSahibi)
        {
            Database database = new Database();

            if (database.baglanti.State == System.Data.ConnectionState.Open)
            {
                database.baglanti.Close(); // bağlantı açıksa bağlantıyı kapat
               
            }

            try
            {
                database.baglanti.Open(); // bağlantı aç
                OracleCommand kayitGuncelle = new OracleCommand("UPDATE ODALAR SET OdaSahibi=:alan_kisi,OdaDurumu=:durum where OdaAdi=:oda_adi", database.baglanti);
                kayitGuncelle.Parameters.Add(new OracleParameter(":alan_kisi", odaSahibi));
                kayitGuncelle.Parameters.Add(new OracleParameter(":durum", "Dolu"));
                kayitGuncelle.Parameters.Add(new OracleParameter(":oda_adi", odaAdi));
                kayitGuncelle.ExecuteNonQuery();
                kayitGuncelle.Dispose();
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {
                database.baglanti.Close(); //  bağlantıyı kapat
            }
        }

        
        public void kayitAl(string ad, string soyad,string cinsiyet,string tc,string oda,string girisTarihi,string cikisTarihi)
        {
            if (database.baglanti.State == System.Data.ConnectionState.Open)
            {
                database.baglanti.Close(); // bağlantı açıksa bağlantıyı kapat
            }
            try
            {
                database.baglanti.Open(); // bağlantıyı aç
                OracleCommand kayitEkle = new OracleCommand("INSERT INTO MUSTERI (MusteriAd,MusteriSoyad,MusteriCinsiyet,MusteriTC,MusteriOda,girisTarihi,cikisTarihi) VALUES(:MusteriAd,:MusteriSoyad,:MusteriCinsiyet,:MusteriTC,:MusteriOda,:girisTarihi,:cikisTarihi)",
                database.baglanti); // insert ifadesi yazılacak
                kayitEkle.Parameters.Add(new OracleParameter(":MusteriAd", ad)); // parametreler üzerinde işlem yapılacak
                kayitEkle.Parameters.Add(new OracleParameter(":MusteriSoyad", soyad));
                kayitEkle.Parameters.Add(new OracleParameter(":MusteriCinsiyet", cinsiyet));
                kayitEkle.Parameters.Add(new OracleParameter(":MusteriTC", tc));
                kayitEkle.Parameters.Add(new OracleParameter(":MusteriOda", oda));
                kayitEkle.Parameters.Add(new OracleParameter(":girisTarihi", girisTarihi));
                kayitEkle.Parameters.Add(new OracleParameter(":cikisTarihi", cikisTarihi));
                kayitEkle.ExecuteNonQuery(); // eklemeleri yap
                System.Windows.Forms.MessageBox.Show("Müşteri kaydınız tamamlandı : "+oda+" adlı oda "+ad+"  "+soyad+" adlı kişiye verilmiştir.","Bilgilendirme Mesajı",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                kayitEkle.Dispose(); // ram bellekten boşaltmaya yarar.

                kisi_Adi_Soyadi_Getir = ad + " " + soyad;
                odaKayitAl(oda, kisi_Adi_Soyadi_Getir);
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }

            finally
            {
                database.baglanti.Close(); // bağlantıyı kapat
            }

        }


    }
}
