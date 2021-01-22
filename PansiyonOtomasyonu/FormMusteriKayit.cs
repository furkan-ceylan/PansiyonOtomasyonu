using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace OtelOtomasyonu
{
    public partial class FormMusteriKayit : Form
    {
        Button seciliButon;

        public FormMusteriKayit()
        {
            InitializeComponent();
        }

        ArrayList odalar = new ArrayList();

        void koltukYaz()
        {
            string oda = "";

            for(int i = 0; i < odalar.Count; i++)
            {
                oda += odalar[i].ToString()+" ,";
            }

            if(odalar.Count >= 1)
            {
                oda = oda.Remove(oda.Length - 1, 1);
            }
            txtOda.Text = oda;
        }

        private void odalaraTikla(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Lime)
            {
                ((Button)sender).BackColor = Color.Yellow;
                seciliButon = ((Button)sender);


                if (!odalar.Contains(((Button)sender).Text)){

                    odalar.Add(((Button)sender).Text);
                }
                koltukYaz();
            }
            else if (((Button)sender).BackColor == Color.Yellow)
            {
                ((Button)sender).BackColor = Color.Lime;

                if (odalar.Contains(((Button)sender).Text))
                {
                    odalar.Remove(((Button)sender).Text);

                }
                koltukYaz();
            }
        }

        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            dateGiris.Format = DateTimePickerFormat.Custom;
            dateGiris.CustomFormat = "dd/MM/yyyy";

            dateCikis.Format = DateTimePickerFormat.Custom;
            dateCikis.CustomFormat = "dd/MM/yyyy";

            girisTarihi = dateGiris.Value;
            cikisTarihi = dateCikis.Value;
            MusteriKayit kayit = new MusteriKayit();

            for(int i = 0; i < odalar.Count; i++)
            {


                string room = odalar[i].ToString();
                kayit.kayitAl(txtAd.Text, txtSoyad.Text, cbCinsiyet.Text, txtTc.Text,room,txtKullaniciAdi.Text,txtSifre.Text,girisTarihi.ToString("dd/MM/yyyy"),cikisTarihi.ToString("dd/MM/yyyy"));
                
            }
            timer1.Start();

            seciliButon.BackColor = Color.Red;

           Odalar odam = new Odalar();
           odam.oda_kayitAl(seciliButon.Text,txtAd.Text+" "+txtSoyad.Text, "Dolu",seciliButon.Name);
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Database database = new Database();

            if (database.baglanti.State == ConnectionState.Open)
            {
                database.baglanti.Close();
            }
            

            try
            {
                database.baglanti.Open();
               OracleCommand OracleCommand = new OracleCommand("SELECT * FROM ODALAR WHERE OdaDurumu=:durum", database.baglanti);
                OracleCommand.Parameters.Add(new OracleParameter(":durum", "Dolu"));
                OracleDataReader OracleDataReader = OracleCommand.ExecuteReader();

                while (OracleDataReader.Read())
                {
                    string buttonName = OracleDataReader["buttonName"].ToString();
                    string odaDurumu = OracleDataReader["odaDurumu"].ToString();

                    if(buttonName=="oda1" && odaDurumu == "Dolu")
                    {
                        oda1.BackColor = Color.Red;
                    }

                    if (buttonName == "oda2" && odaDurumu == "Dolu")
                    {
                        oda2.BackColor = Color.Red;
                    }


                    if (buttonName == "oda3" && odaDurumu == "Dolu")
                    {
                        oda3.BackColor = Color.Red;
                    }

                    if (buttonName == "oda4" && odaDurumu == "Dolu")
                    {
                        oda4.BackColor = Color.Red;
                    }

                    if (buttonName == "oda5" && odaDurumu == "Dolu")
                    {
                        oda5.BackColor = Color.Red;
                    }

                    if (buttonName == "oda6" && odaDurumu == "Dolu")
                    {
                        oda6.BackColor = Color.Red;
                    }

                    if (buttonName == "oda7" && odaDurumu == "Dolu")
                    {
                        oda7.BackColor = Color.Red;
                    }

                    if (buttonName == "oda8" && odaDurumu == "Dolu")
                    {
                        oda8.BackColor = Color.Red;
                    }

                    if (buttonName == "oda9" && odaDurumu == "Dolu")
                    {
                        oda9.BackColor = Color.Red;
                    }

                    if (buttonName == "oda10" && odaDurumu == "Dolu")
                    {
                        oda10.BackColor = Color.Red;
                    }

                    if (buttonName == "oda11" && odaDurumu == "Dolu")
                    {
                        oda11.BackColor = Color.Red;
                    }

                    if (buttonName == "oda12" && odaDurumu == "Dolu")
                    {
                        oda12.BackColor = Color.Red;
                    }
                }

                OracleCommand.Dispose();
                OracleDataReader.Close();
                database.baglanti.Close();
                timer1.Stop();

            }
            catch  (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata);  }
            finally
            {
                database.baglanti.Close();
            }
        }

        private void FormMusteriKayit_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }

}
