
namespace Sifir_Arac_Satis
{
    partial class FrmSatisRaporları
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1014, 471);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(975, 518);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(70, 30);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Satış ID";
            this.columnHeader10.Width = 74;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Müşteri TC";
            this.columnHeader11.Width = 109;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "İsim";
            this.columnHeader12.Width = 93;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Soyisim";
            this.columnHeader13.Width = 121;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Telefon Numarası";
            this.columnHeader14.Width = 153;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Araç Markası";
            this.columnHeader15.Width = 108;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Araç Modeli";
            this.columnHeader16.Width = 101;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Araç Alt Modeli";
            this.columnHeader17.Width = 121;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Satılan Fiyat";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Satış Tarihi";
            // 
            // FrmSatisRaporları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatisRaporları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Raporları";
            this.Load += new System.EventHandler(this.FrmSatisRaporları_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}