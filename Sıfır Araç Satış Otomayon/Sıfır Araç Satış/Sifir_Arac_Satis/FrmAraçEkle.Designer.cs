
namespace Sifir_Arac_Satis
{
    partial class FrmSatilikAraclar
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(980, 511);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(70, 30);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1038, 498);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 37;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Marka";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Alt Model";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tipi";
            this.columnHeader8.Width = 71;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Koltuk S.";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ses S.";
            this.columnHeader10.Width = 72;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Vites";
            this.columnHeader11.Width = 74;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Renk";
            this.columnHeader12.Width = 69;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Yakıt";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "minHP";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "maxHP";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "minCM";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "maxCM";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Stok";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Fiyat";
            // 
            // FrmSatilikAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatilikAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satılık Araçlar";
            this.Load += new System.EventHandler(this.FrmAraçEkle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}