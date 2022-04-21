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
    public partial class FrmRandevuVeServis : Form
    {
        public FrmRandevuVeServis()
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
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from RandevuVeServis", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["bakimID"].ToString();
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["telno"].ToString());
                ekle.SubItems.Add(oku["marka"].ToString());
                ekle.SubItems.Add(oku["model"].ToString());
                ekle.SubItems.Add(oku["altmodel"].ToString());
                ekle.SubItems.Add(oku["aractipi"].ToString());
                ekle.SubItems.Add(oku["randevuTarihi"].ToString());
                ekle.SubItems.Add(oku["randevuSaati"].ToString());
                ekle.SubItems.Add(oku["durum"].ToString());
                ekle.SubItems.Add(oku["toplamFiyat"].ToString());
                ekle.SubItems.Add(oku["ucretYB"].ToString());
                ekle.SubItems.Add(oku["ucretGB"].ToString());
                ekle.SubItems.Add(oku["ucretRB"].ToString());
                ekle.SubItems.Add(oku["ucretElb"].ToString());
                ekle.SubItems.Add(oku["ucretEgB"].ToString());
                ekle.SubItems.Add(oku["ucretChU"].ToString());
                ekle.SubItems.Add(oku["detay1"].ToString());
                ekle.SubItems.Add(oku["detay2"].ToString());
                ekle.SubItems.Add(oku["detay3"].ToString());
                ekle.SubItems.Add(oku["ucretD1"].ToString());
                ekle.SubItems.Add(oku["ucretd2"].ToString());
                ekle.SubItems.Add(oku["ucretD3"].ToString());
                ekle.SubItems.Add(oku["iscilik"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void FrmRandevuVeServis_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtYB.Text = listView1.SelectedItems[0].SubItems[13].Text;
            txtGB.Text = listView1.SelectedItems[0].SubItems[14].Text;
            txtRB.Text = listView1.SelectedItems[0].SubItems[15].Text;
            txtElB.Text = listView1.SelectedItems[0].SubItems[16].Text;
            txtEgB.Text = listView1.SelectedItems[0].SubItems[17].Text;
            txtChU.Text = listView1.SelectedItems[0].SubItems[18].Text;
            txtD1.Text = listView1.SelectedItems[0].SubItems[22].Text;
            txtD2.Text = listView1.SelectedItems[0].SubItems[23].Text;
            txtD3.Text = listView1.SelectedItems[0].SubItems[24].Text;
            txtIscilik.Text = listView1.SelectedItems[0].SubItems[25].Text;
            txtToplam.Text = listView1.SelectedItems[0].SubItems[12].Text;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update RandevuVeServis set ucretYB='" + txtYB.Text + "',ucretGB='" + txtGB.Text + "',ucretRB='" + txtRB.Text + "',ucretElB='" +
                txtElB.Text + "',ucretEgB='" + txtEgB.Text + "',ucretChU='" + txtChU.Text + "',ucretD1='" + txtD1.Text + "',ucretD2='" + txtD2.Text + "',ucretD3='" +
                txtD3.Text + "',iscilik='" + txtIscilik.Text + "',toplamFiyat='" + txtToplam.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Rapor güncellendi.");
            baglanti.Close();
            verileriGoster();
        }

        private void btnYToplam_Click(object sender, EventArgs e)
        {
            int toplam, yb, gb, rb, elb, egb, chu, d1, d2, d3, isci;

            yb = Convert.ToInt32(txtYB.Text);
            gb = Convert.ToInt32(txtGB.Text);
            rb = Convert.ToInt32(txtRB.Text);
            elb = Convert.ToInt32(txtElB.Text);
            egb = Convert.ToInt32(txtEgB.Text);
            chu = Convert.ToInt32(txtChU.Text);
            d1 = Convert.ToInt32(txtD1.Text);
            d2 = Convert.ToInt32(txtD2.Text);
            d3 = Convert.ToInt32(txtD3.Text);
            isci = Convert.ToInt32(txtIscilik.Text);
            toplam = yb + gb + rb + elb + egb + chu + d1 + d2 + d3 + isci;

            txtToplam.Text = Convert.ToString(toplam);
        }
    }
}
