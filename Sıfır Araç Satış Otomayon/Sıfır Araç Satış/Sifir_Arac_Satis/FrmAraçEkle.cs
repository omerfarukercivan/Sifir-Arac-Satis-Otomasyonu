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
    public partial class FrmSatilikAraclar : Form
    {
        public FrmSatilikAraclar()
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
            SqlCommand komut = new SqlCommand("select * from arac", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["aracID"].ToString();
                ekle.SubItems.Add(oku["aracMarka"].ToString());
                ekle.SubItems.Add(oku["aracModel"].ToString());
                ekle.SubItems.Add(oku["aracAltModel"].ToString());
                ekle.SubItems.Add(oku["aracTipi"].ToString());
                ekle.SubItems.Add(oku["koltukSayisi"].ToString());
                ekle.SubItems.Add(oku["sesSistemi"].ToString());
                ekle.SubItems.Add(oku["vites"].ToString());
                ekle.SubItems.Add(oku["renk"].ToString());
                ekle.SubItems.Add(oku["yakitTipi"].ToString());
                ekle.SubItems.Add(oku["minHP"].ToString());
                ekle.SubItems.Add(oku["maxHP"].ToString());
                ekle.SubItems.Add(oku["minCM"].ToString());
                ekle.SubItems.Add(oku["maxCM"].ToString());
                ekle.SubItems.Add(oku["aracStok"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void FrmAraçEkle_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }
    }
}
