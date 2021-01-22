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
    public partial class MüşteriEkrani : Form
    {
        public MüşteriEkrani()
        {
            InitializeComponent();
        }

        private void MüşteriEkrani_Load(object sender, EventArgs e)
        {
            MüşteriEkranı müşteriEkrani = new MüşteriEkranı();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateGirisi.Format = DateTimePickerFormat.Custom;
            dateGirisi.CustomFormat = "dd/MM/yyyy";

            dateCikisi.Format = DateTimePickerFormat.Custom;
            dateCikisi.CustomFormat = "dd/MM/yyyy";

            lblId.Text = dataGridView1.Rows[e.RowIndex].Cells["MusteriID"].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["MusteriAd"].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells["MusteriSoyad"].Value.ToString();
            cbCinsiyeti.Text = dataGridView1.Rows[e.RowIndex].Cells["MusteriCinsiyet"].Value.ToString();
            txtTcsi.Text = dataGridView1.Rows[e.RowIndex].Cells["MusteriTC"].Value.ToString();
            txtOdasi.Text = dataGridView1.Rows[e.RowIndex].Cells["MusteriOda"].Value.ToString();
            dateGirisi.Text = dataGridView1.Rows[e.RowIndex].Cells["girisTarihi"].Value.ToString();
            dateCikisi.Text = dataGridView1.Rows[e.RowIndex].Cells["cikisTarihi"].Value.ToString();
        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            MüşteriEkranı müşteriEkranı = new MüşteriEkranı();
            dataGridView1.DataSource = müşteriEkranı.tablolar();
        }

        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            cbCinsiyeti.Text = "";
            txtTcsi.Text = "";
            txtOdasi.Text = "";
            txtUcreti.Text = "";
            dateGirisi.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            dateCikisi.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateGirisi.Value;
            DateTime cikisTarihi = dateCikisi.Value;
            int id = Convert.ToInt32(lblId.Text);
            MüşteriEkranı me = new MüşteriEkranı();
            me.musterileriGuncelle(id, txtAdi.Text,txtSoyadi.Text, cbCinsiyeti.Text, txtTcsi.Text, txtOdasi.Text, girisTarihi.ToString("dd/MM/yyyy"), cikisTarihi.ToString("dd/MM/yyyy"));
            dataGridView1.DataSource = me.tablolar();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            String oda_adi = txtOdasi.Text;
            Console.WriteLine(oda_adi);

            MüşteriEkranı me = new MüşteriEkranı();
            me.musterilerSil(id, oda_adi);
            dataGridView1.DataSource = me.tablolar();
        }

    }
}
