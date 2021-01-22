using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace OtelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home grs = new Home();
            AnaEkran main = new AnaEkran();
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi doğru giriniz.", "HATA - Pansiyon Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.Login(textBox1.Text, textBox2.Text, DateTime.Now);
                string bilgiTut = textBox1.Text + " " + textBox2.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            FormMusteriKayit musteriKayit = new FormMusteriKayit();
            musteriKayit.Show();
        }

        private void YoneticiGirisButton_Click(object sender, EventArgs e)
        {
            Home grs = new Home();
            MüşteriEkrani MusteriEkraniGiris = new MüşteriEkrani();   
            
            if (txtYoneticiKulAdi.Text == string.Empty || txtYoneticiSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi doğru giriniz.", "HATA - Pansiyon Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.LoginYonetici(txtYoneticiKulAdi.Text, txtYoneticiSifre.Text, DateTime.Now);
                string bilgiTut = txtYoneticiKulAdi.Text + " " + txtYoneticiSifre.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    MusteriEkraniGiris.Show();
                    this.Hide();
                }
            }
        }
    }
}
