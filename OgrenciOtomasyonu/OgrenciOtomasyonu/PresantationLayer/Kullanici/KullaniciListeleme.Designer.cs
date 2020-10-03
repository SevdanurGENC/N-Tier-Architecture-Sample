namespace OgrenciOtomasyonu.Kullanici
{
    partial class KullaniciListeleme
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
            this.rbTumListe = new System.Windows.Forms.RadioButton();
            this.rbSecili = new System.Windows.Forms.RadioButton();
            this.cbKullaniciAdi = new System.Windows.Forms.CheckBox();
            this.cbAd = new System.Windows.Forms.CheckBox();
            this.cbSoyad = new System.Windows.Forms.CheckBox();
            this.cbBirimId = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTumListe
            // 
            this.rbTumListe.AutoSize = true;
            this.rbTumListe.Location = new System.Drawing.Point(20, 18);
            this.rbTumListe.Name = "rbTumListe";
            this.rbTumListe.Size = new System.Drawing.Size(278, 33);
            this.rbTumListe.TabIndex = 1;
            this.rbTumListe.TabStop = true;
            this.rbTumListe.Text = "Tum Listeyi Goruntule";
            this.rbTumListe.UseVisualStyleBackColor = true;
            this.rbTumListe.CheckedChanged += new System.EventHandler(this.rbTumListe_CheckedChanged);
            // 
            // rbSecili
            // 
            this.rbSecili.AutoSize = true;
            this.rbSecili.Location = new System.Drawing.Point(20, 72);
            this.rbSecili.Name = "rbSecili";
            this.rbSecili.Size = new System.Drawing.Size(267, 33);
            this.rbSecili.TabIndex = 3;
            this.rbSecili.TabStop = true;
            this.rbSecili.Text = "Secili Alanlari Listele";
            this.rbSecili.UseVisualStyleBackColor = true;
            this.rbSecili.CheckedChanged += new System.EventHandler(this.rbSecili_CheckedChanged);
            // 
            // cbKullaniciAdi
            // 
            this.cbKullaniciAdi.AutoSize = true;
            this.cbKullaniciAdi.Location = new System.Drawing.Point(93, 125);
            this.cbKullaniciAdi.Name = "cbKullaniciAdi";
            this.cbKullaniciAdi.Size = new System.Drawing.Size(177, 33);
            this.cbKullaniciAdi.TabIndex = 4;
            this.cbKullaniciAdi.Text = "Kullanici Adi";
            this.cbKullaniciAdi.UseVisualStyleBackColor = true;
            // 
            // cbAd
            // 
            this.cbAd.AutoSize = true;
            this.cbAd.Location = new System.Drawing.Point(93, 174);
            this.cbAd.Name = "cbAd";
            this.cbAd.Size = new System.Drawing.Size(80, 33);
            this.cbAd.TabIndex = 5;
            this.cbAd.Text = "Adi";
            this.cbAd.UseVisualStyleBackColor = true;
            // 
            // cbSoyad
            // 
            this.cbSoyad.AutoSize = true;
            this.cbSoyad.Location = new System.Drawing.Point(93, 225);
            this.cbSoyad.Name = "cbSoyad";
            this.cbSoyad.Size = new System.Drawing.Size(119, 33);
            this.cbSoyad.TabIndex = 6;
            this.cbSoyad.Text = "Soyadi";
            this.cbSoyad.UseVisualStyleBackColor = true;
            // 
            // cbBirimId
            // 
            this.cbBirimId.AutoSize = true;
            this.cbBirimId.Location = new System.Drawing.Point(93, 278);
            this.cbBirimId.Name = "cbBirimId";
            this.cbBirimId.Size = new System.Drawing.Size(101, 33);
            this.cbBirimId.TabIndex = 7;
            this.cbBirimId.Text = "Birim";
            this.cbBirimId.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1603, 612);
            this.dataGridView1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListeleme);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.rbTumListe);
            this.panel1.Controls.Add(this.rbSecili);
            this.panel1.Controls.Add(this.cbKullaniciAdi);
            this.panel1.Controls.Add(this.cbBirimId);
            this.panel1.Controls.Add(this.cbAd);
            this.panel1.Controls.Add(this.cbSoyad);
            this.panel1.Location = new System.Drawing.Point(19, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1595, 320);
            this.panel1.TabIndex = 21;
            // 
            // btnListeleme
            // 
            this.btnListeleme.Image = global::OgrenciOtomasyonu.Properties.Resources.search_user1;
            this.btnListeleme.Location = new System.Drawing.Point(1212, 18);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(177, 145);
            this.btnListeleme.TabIndex = 9;
            this.btnListeleme.UseVisualStyleBackColor = true;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = global::OgrenciOtomasyonu.Properties.Resources.home2;
            this.btnCikis.Location = new System.Drawing.Point(1398, 18);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(177, 145);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KullaniciListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1638, 995);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Listeleme Ekrani";
            this.Load += new System.EventHandler(this.KullaniciListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbTumListe;
        private System.Windows.Forms.RadioButton rbSecili;
        private System.Windows.Forms.CheckBox cbKullaniciAdi;
        private System.Windows.Forms.CheckBox cbAd;
        private System.Windows.Forms.CheckBox cbSoyad;
        private System.Windows.Forms.CheckBox cbBirimId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Button btnCikis;
    }
}