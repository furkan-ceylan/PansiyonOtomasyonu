using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OtelOtomasyonu
{
    class MüşteriEkranı
    {

        Database db = new Database();

        public string state { get; set; }

        public string deleteState { get; set; }

        public DataTable tablolar()
        {
            if (db.baglanti.State==ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            try
            {
                db.baglanti.Open();
                OracleCommand verileriAl = new OracleCommand("select * from MUSTERI", db.baglanti);
                OracleDataAdapter adapter = new OracleDataAdapter(verileriAl); // tablodaki verileri saklama yapıyor
                DataTable dataTable = new DataTable(); // tabloda verileri eşleme yapıyor
                adapter.Fill(dataTable); // datatable adapter eklendi
                return dataTable; // datatable döndürme işlemi yapılıyor
                
            }
            catch
            {
                return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        public void musterileriGuncelle(int id, String ad, String soyad, String cinsiyet, String tc, String oda, String girisTarihi, String cikisTarihi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            try
            {
                db.baglanti.Open();

                OracleCommand update = new OracleCommand("UPDATE MUSTERI SET MusteriAd=:ad,MusteriSoyad=:soyad,MusteriCinsiyet=:cinsiyet,MusteriTC=:tc,MusteriOda=:oda,girisTarihi=:girisTarihi,cikisTarihi=:cikisTarihi WHERE MUSTERIID=:id", db.baglanti);
                update.Parameters.Add(new OracleParameter(":ad", ad)); // parametreler üzerinde işlem yapılacak
                update.Parameters.Add(new OracleParameter(":soyad", soyad));
                update.Parameters.Add(new OracleParameter(":cinsiyet", cinsiyet));
                update.Parameters.Add(new OracleParameter(":tc", tc));
                update.Parameters.Add(new OracleParameter(":oda", oda));
                update.Parameters.Add(new OracleParameter(":girisTarihi", girisTarihi));
                update.Parameters.Add(new OracleParameter(":cikisTarihi", cikisTarihi));
                update.Parameters.Add(new OracleParameter(":id", id));
                update.ExecuteNonQuery();
                state = ad + " " + soyad + "isim ve soyisimli kişilerinin verileri güncellendi";

            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {
                db.baglanti.Close();
            }

        }

        public void musterilerSil(int id, String oda_adi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            try
            {
                db.baglanti.Open();
                OracleCommand delete = new OracleCommand("DELETE MUSTERI WHERE MusteriID=:id", db.baglanti);
                delete.Parameters.Add(":id", id);
                delete.ExecuteNonQuery();
                deleteState = "Silme işlemi başarılı bir şekilde gerçekleşti.";

                
                OracleCommand oda_delete = new OracleCommand("DELETE ODALAR WHERE OdaAdi=:ad", db.baglanti);
                oda_delete.Parameters.Add(":ad", oda_adi);
                oda_delete.ExecuteNonQuery();
               

            }
            catch
            {

            }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable musterilerAra(string ad)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            try
            {
                db.baglanti.Open();
                OracleCommand search = new OracleCommand("SELECT * FROM MUSTERI WHERE MusteriAd LIKE'%'+:ad+'%'", db.baglanti);
                search.Parameters.Add(":ad", ad);
                OracleDataAdapter adapter = new OracleDataAdapter(search);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;

            }
            catch
            {
                return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }

    }
}
