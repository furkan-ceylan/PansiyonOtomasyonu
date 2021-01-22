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
    public partial class OdaServisi : Form
    {
        public OdaServisi()
        {
            InitializeComponent();
        }

        private void odaServisiBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oda Servisiniz Geliyor!", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gorevliCagir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görevli Odanıza Geliyor!", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kart kaybı başvurusu yaptınız hemen ilgileneceğiz!", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aracınız Hazırlanıyor!", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menümüz.", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şikayet Ettiniz!", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
