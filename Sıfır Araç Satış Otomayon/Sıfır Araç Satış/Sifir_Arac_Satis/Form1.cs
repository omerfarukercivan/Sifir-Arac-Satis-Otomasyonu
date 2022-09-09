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
//Data Source=DESKTOP-7QDOUC9\\SQLEXPRESS;Initial Catalog=AracSatisServis;Integrated Security=True

namespace Sifir_Arac_Satis
{
    public partial class FrmGirisSayfasi : Form
    {
        public FrmGirisSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-73NEDQR\\SQLEXPRESS;Initial Catalog=AracSatisServis;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from admin where username = @adi AND password = @sifresi";
                SqlParameter ad = new SqlParameter("adi", txtAdminMail.Text.Trim());
                SqlParameter sifre = new SqlParameter("sifresi", txtAdminSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(ad);
                komut.Parameters.Add(sifre);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAdminAnasayfa fr = new FrmAdminAnasayfa();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
