using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OtelOtomasyonu
{
    public class Database
    {
        public OracleConnection baglanti = new OracleConnection("User Id=SYSTEM;Password=root;Data Source=localhost:1521/XEPDB1;");

        OracleCommand komut = new OracleCommand();
        OracleDataAdapter adaptor = new OracleDataAdapter();
        OracleDataReader oku;
        public DataTable tablodoldurma(string komut)
        {

            DataTable tablo = new DataTable();
            this.baglanti.Open();
            this.komut.CommandType = CommandType.Text;
            this.komut.CommandText = komut;
            this.komut.Connection = baglanti;
            adaptor.SelectCommand = this.komut;
            adaptor.Fill(tablo);
            this.baglanti.Close();
            return tablo;
        }
        public OracleDataReader okuyucu(string komut)
        {
            this.baglanti.Open();
            this.komut.Connection = baglanti;
            this.komut.CommandType = CommandType.Text;
            this.komut.CommandText = komut;
            this.oku = this.komut.ExecuteReader();
            return this.oku;

        }
        public void komutCalıstır(string komut)
        {
            this.baglanti.Open();
            this.komut.CommandType = CommandType.Text;
            this.komut.Connection = baglanti;
            this.komut.CommandText = komut;
            this.komut.ExecuteNonQuery();
            this.baglanti.Close();
        }
    }
}
