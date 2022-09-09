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
    public partial class FrmMusteriEkleme : Form
    {
        public FrmMusteriEkleme()
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

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musid"].ToString();
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["soyisim"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telno"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
                ekle.SubItems.Add(oku["sehir"].ToString());
                ekle.SubItems.Add(oku["ulke"].ToString());
                ekle.SubItems.Add(oku["aracTipi"].ToString());
                ekle.SubItems.Add(oku["aracMarkasi"].ToString());
                ekle.SubItems.Add(oku["aracModeli"].ToString());
                ekle.SubItems.Add(oku["aracAltModeli"].ToString());
                ekle.SubItems.Add(oku["aracPlakasi"].ToString());
                ekle.SubItems.Add(oku["yakitTipi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void FrmMusteriEkleme_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        // bağlantı sorunu var !!! aynı tclileri eklememe sorunu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTc.Text == "" || txtMail.Text == "" || cmbCinsiyet.Text == "" ||
                mskbTel.Text == "" || txtAdres.Text == "" || txtSehir.Text == "" || txtUlke.Text == "")
            {
                MessageBox.Show("Müşteri bilgileri eksik girilemez!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand(" insert into musteriler" + "(isim, soyisim, tc, email, cinsiyet, telno, adres, sehir, ulke, aracTipi, aracMarkasi, aracModeli, aracAltModeli, aracPlakasi, yakitTipi)" +
                                "values('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTc.Text + "','" + txtMail.Text + "','" +
                                cmbCinsiyet.Text + "','" + mskbTel.Text + "','" + txtAdres.Text + "','" + txtSehir.Text + "','" + txtUlke.Text + "','" + cmbAracTipi.Text + "','" + cmbAracMarkasi.Text + "','" + txtAracModeli.Text + "','" +
                                txtAracAModeli.Text + "','" + txtPlaka.Text + "','" + cmbYakitTipi.Text + "')", baglanti);
                komut1.ExecuteNonQuery();

                MessageBox.Show("Yeni müşteri başarıyla eklenmiştir.");
            }
            baglanti.Close();
            VerileriGoster();
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteriler where Musid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }
        
        int id = 0;
        
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[5].Text;
            mskbTel.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtAdres.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtSehir.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtUlke.Text = listView1.SelectedItems[0].SubItems[9].Text;
            cmbAracTipi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            cmbAracMarkasi.Text = listView1.SelectedItems[0].SubItems[11].Text;
            txtAracModeli.Text = listView1.SelectedItems[0].SubItems[12].Text;
            txtAracAModeli.Text = listView1.SelectedItems[0].SubItems[13].Text;
            txtPlaka.Text = listView1.SelectedItems[0].SubItems[14].Text;
            cmbYakitTipi.Text = listView1.SelectedItems[0].SubItems[15].Text;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriler set isim= '" + txtAd.Text + "', soyisim='" + txtSoyad.Text + "', tc='" +
                txtTc.Text + "',email= '" + txtMail.Text + "', cinsiyet= '" + cmbCinsiyet.Text + "', telno = '" + mskbTel.Text + "', adres = '" + txtAdres.Text + "', sehir = '" +
                txtSehir.Text + "', ulke = '" + txtUlke.Text + "', aracTipi = '" + cmbAracTipi.Text
                + "', aracMarkasi= '" + cmbAracMarkasi.Text + "', aracModeli= '" + txtAracModeli.Text + "', aracAltModeli= '" + txtAracAModeli.Text + "', aracPlakasi= '" + txtPlaka.Text + "', yakitTipi= '" + cmbYakitTipi.Text + "' where musid = " + id + "", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtMail.Clear();
            cmbCinsiyet.Text = "";
            mskbTel.Clear();
            txtAdres.Clear();
            txtSehir.Clear();
            txtUlke.Clear();
            cmbAracTipi.Text = "";
            cmbAracMarkasi.Text = "";
            txtAracModeli.Clear();
            txtAracAModeli.Clear();
            txtPlaka.Clear();
            cmbYakitTipi.Text = "";
        }
    }
}
