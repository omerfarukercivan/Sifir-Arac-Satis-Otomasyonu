
namespace Sifir_Arac_Satis
{
    partial class FrmYedekParcaVeServis
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMusteriID = new System.Windows.Forms.ComboBox();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracSatisServisDataSet1 = new Sifir_Arac_Satis.AracSatisServisDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAracTipi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.cmbRandevuSaati = new System.Windows.Forms.ComboBox();
            this.txtRandevuTarih = new System.Windows.Forms.TextBox();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnServisDone = new System.Windows.Forms.Button();
            this.txtChUp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIscilik = new System.Windows.Forms.TextBox();
            this.txtD3Fiyat = new System.Windows.Forms.TextBox();
            this.txtD2Fiyat = new System.Windows.Forms.TextBox();
            this.txtD1Fiyat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDetay3 = new System.Windows.Forms.TextBox();
            this.txtDetay2 = new System.Windows.Forms.TextBox();
            this.txtDetay1 = new System.Windows.Forms.TextBox();
            this.txtEgB = new System.Windows.Forms.TextBox();
            this.txtElB = new System.Windows.Forms.TextBox();
            this.txtRB = new System.Windows.Forms.TextBox();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtYB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.musterilerTableAdapter = new Sifir_Arac_Satis.AracSatisServisDataSet1TableAdapters.musterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracSatisServisDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.v.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alt Model:";
            // 
            // cmbMusteriID
            // 
            this.cmbMusteriID.DataSource = this.musterilerBindingSource;
            this.cmbMusteriID.DisplayMember = "tc";
            this.cmbMusteriID.FormattingEnabled = true;
            this.cmbMusteriID.Location = new System.Drawing.Point(88, 39);
            this.cmbMusteriID.Name = "cmbMusteriID";
            this.cmbMusteriID.Size = new System.Drawing.Size(136, 24);
            this.cmbMusteriID.TabIndex = 5;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this.aracSatisServisDataSet1;
            // 
            // aracSatisServisDataSet1
            // 
            this.aracSatisServisDataSet1.DataSetName = "AracSatisServisDataSet1";
            this.aracSatisServisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(87, 74);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(136, 22);
            this.txtAd.TabIndex = 7;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(88, 132);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(136, 22);
            this.txtMarka.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(87, 165);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(136, 22);
            this.txtModel.TabIndex = 9;
            // 
            // txtAModel
            // 
            this.txtAModel.Location = new System.Drawing.Point(87, 201);
            this.txtAModel.Name = "txtAModel";
            this.txtAModel.Size = new System.Drawing.Size(136, 22);
            this.txtAModel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Araç Tipi:";
            // 
            // txtAracTipi
            // 
            this.txtAracTipi.Location = new System.Drawing.Point(86, 236);
            this.txtAracTipi.Name = "txtAracTipi";
            this.txtAracTipi.Size = new System.Drawing.Size(136, 22);
            this.txtAracTipi.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAracTipi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAModel);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbMusteriID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Detayları";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "Soyadı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(88, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(136, 22);
            this.txtSoyad.TabIndex = 14;
            // 
            // v
            // 
            this.v.BackColor = System.Drawing.SystemColors.Control;
            this.v.Controls.Add(this.txtTelNo);
            this.v.Controls.Add(this.label20);
            this.v.Controls.Add(this.monthCalendar2);
            this.v.Controls.Add(this.cmbRandevuSaati);
            this.v.Controls.Add(this.txtRandevuTarih);
            this.v.Controls.Add(this.btnRandevuOlustur);
            this.v.Controls.Add(this.label8);
            this.v.Controls.Add(this.label7);
            this.v.Location = new System.Drawing.Point(387, 12);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(663, 281);
            this.v.TabIndex = 2;
            this.v.TabStop = false;
            this.v.Text = "Randevu Detayları";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(131, 104);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(136, 22);
            this.txtTelNo.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 17);
            this.label20.TabIndex = 16;
            this.label20.Text = "Telefon Numarası:";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(334, 16);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 15;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // cmbRandevuSaati
            // 
            this.cmbRandevuSaati.FormattingEnabled = true;
            this.cmbRandevuSaati.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbRandevuSaati.Location = new System.Drawing.Point(132, 70);
            this.cmbRandevuSaati.Name = "cmbRandevuSaati";
            this.cmbRandevuSaati.Size = new System.Drawing.Size(135, 24);
            this.cmbRandevuSaati.TabIndex = 14;
            // 
            // txtRandevuTarih
            // 
            this.txtRandevuTarih.Location = new System.Drawing.Point(131, 36);
            this.txtRandevuTarih.Name = "txtRandevuTarih";
            this.txtRandevuTarih.Size = new System.Drawing.Size(136, 22);
            this.txtRandevuTarih.TabIndex = 13;
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.Location = new System.Drawing.Point(19, 191);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(100, 50);
            this.btnRandevuOlustur.TabIndex = 2;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = true;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Randevu Saati:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Randevu Tarihi:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeri.Location = new System.Drawing.Point(975, 518);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(70, 30);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnServisDone);
            this.groupBox2.Controls.Add(this.txtChUp);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtToplam);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtIscilik);
            this.groupBox2.Controls.Add(this.txtD3Fiyat);
            this.groupBox2.Controls.Add(this.txtD2Fiyat);
            this.groupBox2.Controls.Add(this.txtD1Fiyat);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDetay3);
            this.groupBox2.Controls.Add(this.txtDetay2);
            this.groupBox2.Controls.Add(this.txtDetay1);
            this.groupBox2.Controls.Add(this.txtEgB);
            this.groupBox2.Controls.Add(this.txtElB);
            this.groupBox2.Controls.Add(this.txtRB);
            this.groupBox2.Controls.Add(this.txtGB);
            this.groupBox2.Controls.Add(this.txtYB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 242);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servis Detayları";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(768, 142);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(78, 30);
            this.btnHesapla.TabIndex = 38;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnServisDone
            // 
            this.btnServisDone.Location = new System.Drawing.Point(851, 186);
            this.btnServisDone.Name = "btnServisDone";
            this.btnServisDone.Size = new System.Drawing.Size(100, 50);
            this.btnServisDone.TabIndex = 37;
            this.btnServisDone.Text = "Servis Tamamlandı";
            this.btnServisDone.UseVisualStyleBackColor = true;
            this.btnServisDone.Click += new System.EventHandler(this.btnServisDone_Click);
            // 
            // txtChUp
            // 
            this.txtChUp.Location = new System.Drawing.Point(375, 163);
            this.txtChUp.Name = "txtChUp";
            this.txtChUp.Size = new System.Drawing.Size(85, 22);
            this.txtChUp.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(295, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "Check-Up:";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(695, 195);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(66, 22);
            this.txtToplam.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(630, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Toplam:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(603, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "İşçilik Ücreti:";
            // 
            // txtIscilik
            // 
            this.txtIscilik.Location = new System.Drawing.Point(695, 142);
            this.txtIscilik.Name = "txtIscilik";
            this.txtIscilik.Size = new System.Drawing.Size(66, 22);
            this.txtIscilik.TabIndex = 29;
            // 
            // txtD3Fiyat
            // 
            this.txtD3Fiyat.Location = new System.Drawing.Point(695, 114);
            this.txtD3Fiyat.Name = "txtD3Fiyat";
            this.txtD3Fiyat.Size = new System.Drawing.Size(66, 22);
            this.txtD3Fiyat.TabIndex = 28;
            // 
            // txtD2Fiyat
            // 
            this.txtD2Fiyat.Location = new System.Drawing.Point(695, 86);
            this.txtD2Fiyat.Name = "txtD2Fiyat";
            this.txtD2Fiyat.Size = new System.Drawing.Size(66, 22);
            this.txtD2Fiyat.TabIndex = 27;
            // 
            // txtD1Fiyat
            // 
            this.txtD1Fiyat.Location = new System.Drawing.Point(695, 58);
            this.txtD1Fiyat.Name = "txtD1Fiyat";
            this.txtD1Fiyat.Size = new System.Drawing.Size(66, 22);
            this.txtD1Fiyat.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(706, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Fiyat";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(556, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Yedek Parça Detayı";
            // 
            // txtDetay3
            // 
            this.txtDetay3.Location = new System.Drawing.Point(553, 115);
            this.txtDetay3.Name = "txtDetay3";
            this.txtDetay3.Size = new System.Drawing.Size(136, 22);
            this.txtDetay3.TabIndex = 20;
            // 
            // txtDetay2
            // 
            this.txtDetay2.Location = new System.Drawing.Point(553, 86);
            this.txtDetay2.Name = "txtDetay2";
            this.txtDetay2.Size = new System.Drawing.Size(136, 22);
            this.txtDetay2.TabIndex = 19;
            // 
            // txtDetay1
            // 
            this.txtDetay1.Location = new System.Drawing.Point(553, 58);
            this.txtDetay1.Name = "txtDetay1";
            this.txtDetay1.Size = new System.Drawing.Size(136, 22);
            this.txtDetay1.TabIndex = 18;
            // 
            // txtEgB
            // 
            this.txtEgB.Location = new System.Drawing.Point(375, 112);
            this.txtEgB.Name = "txtEgB";
            this.txtEgB.Size = new System.Drawing.Size(85, 22);
            this.txtEgB.TabIndex = 17;
            // 
            // txtElB
            // 
            this.txtElB.Location = new System.Drawing.Point(375, 58);
            this.txtElB.Name = "txtElB";
            this.txtElB.Size = new System.Drawing.Size(85, 22);
            this.txtElB.TabIndex = 16;
            // 
            // txtRB
            // 
            this.txtRB.Location = new System.Drawing.Point(137, 163);
            this.txtRB.Name = "txtRB";
            this.txtRB.Size = new System.Drawing.Size(85, 22);
            this.txtRB.TabIndex = 15;
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(137, 110);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(85, 22);
            this.txtGB.TabIndex = 14;
            // 
            // txtYB
            // 
            this.txtYB.Location = new System.Drawing.Point(137, 55);
            this.txtYB.Name = "txtYB";
            this.txtYB.Size = new System.Drawing.Size(85, 22);
            this.txtYB.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Egzoz Bakımı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Elektrik Bakımı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rotbalans Ayarı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Genel Bakım:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Yağ Bakımı:";
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmYedekParcaVeServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.v);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYedekParcaVeServis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedek Parça ve Servis";
            this.Load += new System.EventHandler(this.FrmYedekParcaVeServis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracSatisServisDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.v.ResumeLayout(false);
            this.v.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMusteriID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtAModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAracTipi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox v;
        private System.Windows.Forms.ComboBox cmbRandevuSaati;
        private System.Windows.Forms.TextBox txtRandevuTarih;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEgB;
        private System.Windows.Forms.TextBox txtElB;
        private System.Windows.Forms.TextBox txtRB;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.TextBox txtYB;
        private System.Windows.Forms.TextBox txtDetay3;
        private System.Windows.Forms.TextBox txtDetay2;
        private System.Windows.Forms.TextBox txtDetay1;
        private System.Windows.Forms.TextBox txtChUp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIscilik;
        private System.Windows.Forms.TextBox txtD3Fiyat;
        private System.Windows.Forms.TextBox txtD2Fiyat;
        private System.Windows.Forms.TextBox txtD1Fiyat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnServisDone;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label20;
        private AracSatisServisDataSet1 aracSatisServisDataSet1;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private AracSatisServisDataSet1TableAdapters.musterilerTableAdapter musterilerTableAdapter;
    }
}