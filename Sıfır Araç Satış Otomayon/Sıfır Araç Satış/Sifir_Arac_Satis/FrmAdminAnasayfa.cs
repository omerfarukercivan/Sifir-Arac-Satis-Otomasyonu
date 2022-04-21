using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifir_Arac_Satis
{
    public partial class FrmAdminAnasayfa : Form
    {
        public FrmAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            FrmSatilikAraclar fr = new FrmSatilikAraclar();
            fr.Show();
            this.Close();
        }

        private void btnAracDetay_Click(object sender, EventArgs e)
        {
            FrmAracDetayEkle fr = new FrmAracDetayEkle();
            fr.Show();
            this.Close();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkleme fr = new FrmMusteriEkleme();
            fr.Show();
            this.Close();
        }

        private void btnAracSat_Click(object sender, EventArgs e)
        {
            FrmAracSatis fr = new FrmAracSatis();
            fr.Show();
            this.Close();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevuVeServis fr = new FrmRandevuVeServis();
            fr.Show();
            this.Close();
        }

        private void btnSatisRapor_Click(object sender, EventArgs e)
        {
            FrmSatisRaporları fr = new FrmSatisRaporları();
            fr.Show();
            this.Close();
        }

        private void btnYedek_Click(object sender, EventArgs e)
        {
            FrmYedekParcaVeServis fr = new FrmYedekParcaVeServis();
            fr.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
