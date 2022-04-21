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
    public partial class FrmAracDetayEkle : Form
    {
        public FrmAracDetayEkle()
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbAracMarka.Text == "" || txtAracModel.Text == "" ||txtAracAltModel.Text == "" || cmbAracTipi.Text == "" || txtKoltukSayisi.Text == "" || 
                cmbSesSistemi.Text == "" || cmbVites.Text == "" || cmbRenk.Text == "" || cmbYakitTipi.Text == "" || txtMinHP.Text == "" || 
                txtMinCM.Text == "" || txtAracStogu.Text == "" || txtAracFiyat.Text == "")
            {
                MessageBox.Show("Eksik bilgiler girdiniz. Her alanı doldurmak zorunludur!");
            }
            else
            {
                try
                {
                    string marka, model, altmodel, tip, koltuk, ses, vites, renk, yakit, minhp, maxhp, mincm, maxcm, fiyat;
                    int stok;
                    marka = cmbAracMarka.Text;
                    model = txtAracModel.Text;
                    altmodel = txtAracAltModel.Text;
                    tip = cmbAracTipi.Text;
                    koltuk = txtKoltukSayisi.Text;
                    ses = cmbSesSistemi.Text;
                    vites = cmbVites.Text;
                    renk = cmbRenk.Text;
                    yakit = cmbYakitTipi.Text;
                    minhp = txtMinHP.Text;
                    maxhp = txtMaxHP.Text;
                    mincm = txtMinCM.Text;
                    maxcm = txtMaxCM.Text;
                    stok = Convert.ToInt32(txtAracStogu.Text);
                    fiyat = txtAracFiyat.Text;

                    baglanti.Open();

                    SqlCommand komut = new SqlCommand(" insert into arac" + "(aracMarka, aracModel, aracAltModel, aracTipi, koltukSayisi, sesSistemi, vites, renk, yakitTipi, minHP, maxHP, minCM, maxCM, aracStok, fiyat)" +
                        "values('" + marka + "','" + model + "','" + altmodel + "','" + tip + "','" + koltuk + "','" + ses + "','" + vites + "','" + renk + "','" + yakit + "','" + minhp +
                        "','" + maxhp + "','" + mincm + "','" + maxcm + "','" + stok + "','" + fiyat + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Yeni araç başarıyla eklenmiştir.");


                }
                catch(Exception)
                {
                    MessageBox.Show("Kayıt başarısız!!");
                }

                

            }
                
        }
    }
}
