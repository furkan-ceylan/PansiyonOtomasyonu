namespace OtelOtomasyonu
{
    partial class FormMusteriKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.oda1 = new System.Windows.Forms.Button();
            this.oda2 = new System.Windows.Forms.Button();
            this.oda3 = new System.Windows.Forms.Button();
            this.oda6 = new System.Windows.Forms.Button();
            this.oda5 = new System.Windows.Forms.Button();
            this.oda4 = new System.Windows.Forms.Button();
            this.oda9 = new System.Windows.Forms.Button();
            this.oda8 = new System.Windows.Forms.Button();
            this.oda7 = new System.Windows.Forms.Button();
            this.oda12 = new System.Windows.Forms.Button();
            this.oda11 = new System.Windows.Forms.Button();
            this.oda10 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOdaVer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CİNSİYET :";
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cbCinsiyet.Location = new System.Drawing.Point(98, 101);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cbCinsiyet.TabIndex = 5;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(98, 143);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC NO :";
            // 
            // txtOda
            // 
            this.txtOda.Location = new System.Drawing.Point(98, 247);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(100, 20);
            this.txtOda.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // dateGiris
            // 
            this.dateGiris.CustomFormat = "";
            this.dateGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiris.Location = new System.Drawing.Point(98, 280);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(100, 20);
            this.dateGiris.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "GİRİŞ  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ÇIKIŞ :";
            // 
            // dateCikis
            // 
            this.dateCikis.CustomFormat = "";
            this.dateCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCikis.Location = new System.Drawing.Point(98, 325);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(100, 20);
            this.dateCikis.TabIndex = 15;
            // 
            // oda1
            // 
            this.oda1.BackColor = System.Drawing.Color.Lime;
            this.oda1.ForeColor = System.Drawing.Color.Black;
            this.oda1.Location = new System.Drawing.Point(314, 36);
            this.oda1.Name = "oda1";
            this.oda1.Size = new System.Drawing.Size(59, 54);
            this.oda1.TabIndex = 16;
            this.oda1.Text = "ODA1";
            this.oda1.UseVisualStyleBackColor = false;
            this.oda1.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda2
            // 
            this.oda2.BackColor = System.Drawing.Color.Lime;
            this.oda2.ForeColor = System.Drawing.Color.Black;
            this.oda2.Location = new System.Drawing.Point(390, 36);
            this.oda2.Name = "oda2";
            this.oda2.Size = new System.Drawing.Size(59, 54);
            this.oda2.TabIndex = 17;
            this.oda2.Text = "ODA2";
            this.oda2.UseVisualStyleBackColor = false;
            this.oda2.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda3
            // 
            this.oda3.BackColor = System.Drawing.Color.Lime;
            this.oda3.ForeColor = System.Drawing.Color.Black;
            this.oda3.Location = new System.Drawing.Point(464, 36);
            this.oda3.Name = "oda3";
            this.oda3.Size = new System.Drawing.Size(59, 54);
            this.oda3.TabIndex = 18;
            this.oda3.Text = "ODA3";
            this.oda3.UseVisualStyleBackColor = false;
            this.oda3.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda6
            // 
            this.oda6.BackColor = System.Drawing.Color.Lime;
            this.oda6.ForeColor = System.Drawing.Color.Black;
            this.oda6.Location = new System.Drawing.Point(464, 111);
            this.oda6.Name = "oda6";
            this.oda6.Size = new System.Drawing.Size(59, 54);
            this.oda6.TabIndex = 21;
            this.oda6.Text = "ODA6";
            this.oda6.UseVisualStyleBackColor = false;
            this.oda6.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda5
            // 
            this.oda5.BackColor = System.Drawing.Color.Lime;
            this.oda5.ForeColor = System.Drawing.Color.Black;
            this.oda5.Location = new System.Drawing.Point(390, 111);
            this.oda5.Name = "oda5";
            this.oda5.Size = new System.Drawing.Size(59, 54);
            this.oda5.TabIndex = 20;
            this.oda5.Text = "ODA5";
            this.oda5.UseVisualStyleBackColor = false;
            this.oda5.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda4
            // 
            this.oda4.BackColor = System.Drawing.Color.Lime;
            this.oda4.ForeColor = System.Drawing.Color.Black;
            this.oda4.Location = new System.Drawing.Point(314, 111);
            this.oda4.Name = "oda4";
            this.oda4.Size = new System.Drawing.Size(59, 54);
            this.oda4.TabIndex = 19;
            this.oda4.Text = "ODA4";
            this.oda4.UseVisualStyleBackColor = false;
            this.oda4.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda9
            // 
            this.oda9.BackColor = System.Drawing.Color.Lime;
            this.oda9.ForeColor = System.Drawing.Color.Black;
            this.oda9.Location = new System.Drawing.Point(464, 191);
            this.oda9.Name = "oda9";
            this.oda9.Size = new System.Drawing.Size(59, 54);
            this.oda9.TabIndex = 24;
            this.oda9.Text = "ODA9";
            this.oda9.UseVisualStyleBackColor = false;
            this.oda9.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda8
            // 
            this.oda8.BackColor = System.Drawing.Color.Lime;
            this.oda8.ForeColor = System.Drawing.Color.Black;
            this.oda8.Location = new System.Drawing.Point(390, 191);
            this.oda8.Name = "oda8";
            this.oda8.Size = new System.Drawing.Size(59, 54);
            this.oda8.TabIndex = 23;
            this.oda8.Text = "ODA8";
            this.oda8.UseVisualStyleBackColor = false;
            this.oda8.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda7
            // 
            this.oda7.BackColor = System.Drawing.Color.Lime;
            this.oda7.ForeColor = System.Drawing.Color.Black;
            this.oda7.Location = new System.Drawing.Point(314, 191);
            this.oda7.Name = "oda7";
            this.oda7.Size = new System.Drawing.Size(59, 54);
            this.oda7.TabIndex = 22;
            this.oda7.Text = "ODA7";
            this.oda7.UseVisualStyleBackColor = false;
            this.oda7.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda12
            // 
            this.oda12.BackColor = System.Drawing.Color.Lime;
            this.oda12.ForeColor = System.Drawing.Color.Black;
            this.oda12.Location = new System.Drawing.Point(464, 265);
            this.oda12.Name = "oda12";
            this.oda12.Size = new System.Drawing.Size(59, 54);
            this.oda12.TabIndex = 27;
            this.oda12.Text = "ODA12";
            this.oda12.UseVisualStyleBackColor = false;
            this.oda12.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda11
            // 
            this.oda11.BackColor = System.Drawing.Color.Lime;
            this.oda11.ForeColor = System.Drawing.Color.Black;
            this.oda11.Location = new System.Drawing.Point(390, 265);
            this.oda11.Name = "oda11";
            this.oda11.Size = new System.Drawing.Size(59, 54);
            this.oda11.TabIndex = 26;
            this.oda11.Text = "ODA11";
            this.oda11.UseVisualStyleBackColor = false;
            this.oda11.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // oda10
            // 
            this.oda10.BackColor = System.Drawing.Color.Lime;
            this.oda10.ForeColor = System.Drawing.Color.Black;
            this.oda10.Location = new System.Drawing.Point(314, 265);
            this.oda10.Name = "oda10";
            this.oda10.Size = new System.Drawing.Size(59, 54);
            this.oda10.TabIndex = 25;
            this.oda10.Text = "ODA10";
            this.oda10.UseVisualStyleBackColor = false;
            this.oda10.Click += new System.EventHandler(this.odalaraTikla);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(471, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Dolu Oda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(325, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Boş Oda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(394, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Seçili Oda";
            // 
            // btnOdaVer
            // 
            this.btnOdaVer.BackColor = System.Drawing.Color.Salmon;
            this.btnOdaVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaVer.Location = new System.Drawing.Point(114, 366);
            this.btnOdaVer.Name = "btnOdaVer";
            this.btnOdaVer.Size = new System.Drawing.Size(84, 36);
            this.btnOdaVer.TabIndex = 31;
            this.btnOdaVer.Text = "Odayı Ver";
            this.btnOdaVer.UseVisualStyleBackColor = false;
            this.btnOdaVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Şifre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "SEÇİLİ ODA :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(98, 180);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 34;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(98, 214);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 35;
            // 
            // FormMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(560, 414);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOdaVer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.oda12);
            this.Controls.Add(this.oda11);
            this.Controls.Add(this.oda10);
            this.Controls.Add(this.oda9);
            this.Controls.Add(this.oda8);
            this.Controls.Add(this.oda7);
            this.Controls.Add(this.oda6);
            this.Controls.Add(this.oda5);
            this.Controls.Add(this.oda4);
            this.Controls.Add(this.oda3);
            this.Controls.Add(this.oda2);
            this.Controls.Add(this.oda1);
            this.Controls.Add(this.dateCikis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateGiris);
            this.Controls.Add(this.txtOda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "FormMusteriKayit";
            this.Text = "Müşteri Kayıt";
            this.Load += new System.EventHandler(this.FormMusteriKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.Button oda1;
        private System.Windows.Forms.Button oda2;
        private System.Windows.Forms.Button oda3;
        private System.Windows.Forms.Button oda6;
        private System.Windows.Forms.Button oda5;
        private System.Windows.Forms.Button oda4;
        private System.Windows.Forms.Button oda9;
        private System.Windows.Forms.Button oda8;
        private System.Windows.Forms.Button oda7;
        private System.Windows.Forms.Button oda12;
        private System.Windows.Forms.Button oda11;
        private System.Windows.Forms.Button oda10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOdaVer;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker time1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
    }
}