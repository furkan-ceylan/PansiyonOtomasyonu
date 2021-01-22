using System;
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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMusteriOdaSecimi kayitEkrani = new FormMusteriOdaSecimi();
            kayitEkrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriEkrani müsteriEkrani = new MüşteriEkrani();
            müsteriEkrani.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            media.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdaServisi odaServis = new OdaServisi();
            odaServis.Show();
        }
    }
}
