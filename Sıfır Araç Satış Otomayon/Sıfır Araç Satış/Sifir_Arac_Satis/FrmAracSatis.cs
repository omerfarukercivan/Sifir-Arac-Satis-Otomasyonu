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
    public partial class FrmAracSatis : Form
    {
        public FrmAracSatis()
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

        private void FrmAracSatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracSatisServisDataSet1.arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aracTableAdapter.Fill(this.aracSatisServisDataSet1.arac);
            // TODO: Bu kod satırı 'aracSatisServisDataSet1.musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.aracSatisServisDataSet1.musteriler);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.musterilerTableAdapter.FillBy(this.aracSatisServisDataSet1.musteriler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void verileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler where tc like '"+cmbMusteriTC.Text+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                txtAd.Text = oku["isim"].ToString();
                txtSoyad.Text = oku["soyisim"].ToString();
                mskTel.Text = oku["telno"].ToString();
                txtMail.Text = oku["email"].ToString();

            }
            baglanti.Close();
        }
        private void sil()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTel.Text = "";
            txtMail.Text = "";
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            sil();
            verileriGoster();

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.aracTableAdapter.FillBy(this.aracSatisServisDataSet1.arac);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac where aracMarka like '%" + txtAracMarka.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["aracID"].ToString();
                ekle.SubItems.Add(oku["aracMarka"].ToString());
                ekle.SubItems.Add(oku["aracModel"].ToString());
                ekle.SubItems.Add(oku["aracAltModel"].ToString());
                ekle.SubItems.Add(oku["aracTipi"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["koltukSayisi"].ToString());
                ekle.SubItems.Add(oku["sesSistemi"].ToString());
                ekle.SubItems.Add(oku["vites"].ToString());
                ekle.SubItems.Add(oku["renk"].ToString());
                ekle.SubItems.Add(oku["yakitTipi"].ToString());
                ekle.SubItems.Add(oku["MinHP"].ToString());
                ekle.SubItems.Add(oku["MaxHP"].ToString());
                ekle.SubItems.Add(oku["MinCM"].ToString());
                ekle.SubItems.Add(oku["MaxCm"].ToString());
                ekle.SubItems.Add(oku["aracStok"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        int id = 0;
        
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtMarka.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtModel.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtAModel.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtAracTipi.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtSesSist.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtVites.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtRenk.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtYakitTipi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            txtMinHP.Text = listView1.SelectedItems[0].SubItems[11].Text;
            txtMaxHP.Text = listView1.SelectedItems[0].SubItems[12].Text;
            txtMinCM.Text = listView1.SelectedItems[0].SubItems[13].Text;
            txtMaxCM.Text = listView1.SelectedItems[0].SubItems[14].Text;
            txtStok.Text = listView1.SelectedItems[0].SubItems[15].Text;
            txtFiyat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            
        }

        private void txtAModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tarih;
            tarih = DateTime.Now.ToString();
            SqlCommand komut = new SqlCommand("insert into satislar"+
                "(musteriTC,isim,soyisim,telNo,marka,model,altModel,fiyat,satisTarihi)"+
                "values('"+cmbMusteriTC.Text+"','"+txtAd.Text+"','"+txtSoyad.Text+"','"+mskTel.Text+"','"+
                txtMarka.Text+"','"+txtModel.Text+"','"+txtAModel.Text+"','"+txtFiyat.Text+"','"+tarih+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bir araç satıldı.");
            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("update arac set aracStok = aracStok-1 where aracID='"+id+"'",baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
