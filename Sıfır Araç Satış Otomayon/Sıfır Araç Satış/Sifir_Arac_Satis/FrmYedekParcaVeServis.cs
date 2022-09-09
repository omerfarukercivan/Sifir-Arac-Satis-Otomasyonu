using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sifir_Arac_Satis
{
    public partial class FrmYedekParcaVeServis : Form
    {
        public FrmYedekParcaVeServis()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-73NEDQR\\SQLEXPRESS;Initial Catalog=AracSatisServis;Integrated Security=True");
        
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAdminAnasayfa fr = new FrmAdminAnasayfa();
            fr.Show();
            this.Close();
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtRandevuTarih.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }
        
        private void verileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler where tc like '" + cmbMusteriID.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtAd.Text = oku["isim"].ToString();
                txtSoyad.Text = oku["soyisim"].ToString();
                txtTelNo.Text = oku["telno"].ToString();
                txtMarka.Text = oku["aracMarkasi"].ToString();
                txtModel.Text = oku["aracModeli"].ToString();
                txtAModel.Text = oku["aracAltModeli"].ToString();
                txtAracTipi.Text = oku["aracTipi"].ToString();
            }
            baglanti.Close();
        }
        
        private void sil()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelNo.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtAModel.Text = "";
            txtAracTipi.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sil();
            verileriGoster();
        }

        private void FrmYedekParcaVeServis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracSatisServisDataSet1.musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.aracSatisServisDataSet1.musteriler);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.musterilerTableAdapter.FillBy1(this.aracSatisServisDataSet1.musteriler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string durum = "Devam ediyor.";
            SqlCommand komut = new SqlCommand("insert into RandevuVeServis"+"(tc,adi,soyadi,telno,marka,model,altmodel,aractipi,randevuTarihi,randevuSaati,durum)"+
                "values('"+cmbMusteriID.Text+"','"+txtAd.Text+"','"+txtSoyad.Text+"','"+txtTelNo.Text+"','"+txtMarka.Text+"','"+txtModel.Text+"','"+txtAModel.Text
                +"','"+txtAracTipi.Text+"','"+txtRandevuTarih.Text+"','"+cmbRandevuSaati.Text+"','"+durum+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("1 randevu oluşturuldu.");
            baglanti.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam, yb, gb, rb, elb, egb, chu, d1, d2, d3, isci;

            yb = Convert.ToInt32(txtYB.Text);
            gb = Convert.ToInt32(txtGB.Text);
            rb = Convert.ToInt32(txtRB.Text);
            elb = Convert.ToInt32(txtElB.Text);
            egb = Convert.ToInt32(txtEgB.Text);
            chu = Convert.ToInt32(txtChUp.Text);
            d1 = Convert.ToInt32(txtD1Fiyat.Text);
            d2 = Convert.ToInt32(txtD2Fiyat.Text);
            d3 = Convert.ToInt32(txtD3Fiyat.Text);
            isci = Convert.ToInt32(txtIscilik.Text);
            toplam = yb + gb + rb + elb + egb + chu + d1 + d2 + d3 + isci;

            txtToplam.Text = Convert.ToString(toplam);
            string id;
            id = cmbMusteriID.Text;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update RandevuVeServis set ucretYB= '" + txtYB.Text + "', ucretGB='" + txtGB.Text + "',ucretRB='" + txtRB.Text + "',ucretElB= '" + txtElB.Text + "',ucretEgB= '" + txtEgB.Text + "', ucretChU= '" + txtChUp.Text + "', detay1 = '" + txtDetay1.Text + "', detay2= '" +
                txtDetay2.Text + "', detay3= '" + txtDetay3.Text + "', ucretD1= '" + txtD1Fiyat.Text + "', ucretD2= '" + txtD2Fiyat.Text + "', ucretD3= '" + txtD3Fiyat.Text + "', iscilik = '" + txtIscilik.Text + "', toplamFiyat = '" + txtToplam.Text
                + "' where tc = " + id + "", baglanti);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Servis detayı eklendi");
            baglanti.Close(); 
        }

        private void btnServisDone_Click(object sender, EventArgs e)
        {
            string id;
            id = cmbMusteriID.Text;
            baglanti.Open();
            string yeniDurum = "Servis tamamlandı.";
            SqlCommand komut = new SqlCommand("update RandevuVeServis set durum='"+yeniDurum+"' where tc ='"+id+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Servis tamamlandı ve rapor güncellendi!!");
        }
    }
}
