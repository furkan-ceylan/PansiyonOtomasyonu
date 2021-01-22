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

namespace OtelOtomasyonu
{
    public partial class FormOdalarımız : Form
    {
        public FormOdalarımız()
        {
            InitializeComponent();
        }

        ArrayList rooms = new ArrayList(); // array list tanımladık

        private void FormOdalarımız_Load(object sender, EventArgs e)
        {
            string roomName = "";
            string newValue = "";
           // bool durum_ne=false;
            for(int i = 1; i < this.Controls.Count+1; i++) // değeri kadar döndür
            {
                roomName = Convert.ToString(this.Controls.Find("oda"+i.ToString(),true).FirstOrDefault() as Button);
                newValue = roomName.Split(':').Last(); // son kısmını al
                rooms.Add(newValue); // odalara yeni değer eklendi
               // durum_ne = true;
            }

            // if (durum_ne == true)
            // {
            //    OdaDurum();

            // }

            OdaDurum();
        }


        void OdaDurum()
        {
            Odalar odalar = new Odalar();
          //  string yeniOda = "";
            try
            {
                foreach(string odaAdi in rooms)
                {
                    odalar.odaDeger(odaAdi, "Dolu");

                    if (odalar.state == "Dolu")
                    {
                       
                        this.Controls.Find(odalar.buttonAdi, true)[0].BackColor = Color.Red;
                        this.Controls.Find(odalar.buttonAdi,true)[0].Text= odaAdi + "\n"+odalar.buyPerson+"\n";
                       
                    }

                    if (odalar.state == "Boş")
                    {
                        this.Controls.Find(odalar.buttonAdi, true)[0].BackColor = Color.Green;
                    }

                }
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {

            }

        }

    }
}
