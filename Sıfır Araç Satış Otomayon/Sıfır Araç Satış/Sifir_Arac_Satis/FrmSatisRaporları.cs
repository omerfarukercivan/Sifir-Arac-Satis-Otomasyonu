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
    public partial class FrmSatisRaporları : Form
    {
        public FrmSatisRaporları()
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select  * from satislar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["satisID"].ToString();
                ekle.SubItems.Add(oku["musteriTC"].ToString());
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["soyisim"].ToString());
                ekle.SubItems.Add(oku["telNo"].ToString());
                ekle.SubItems.Add(oku["marka"].ToString());
                ekle.SubItems.Add(oku["model"].ToString());
                ekle.SubItems.Add(oku["altModel"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["satisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void FrmSatisRaporları_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }
    }
}
