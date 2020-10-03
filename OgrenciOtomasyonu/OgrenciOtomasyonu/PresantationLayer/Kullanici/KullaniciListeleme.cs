using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyonu.Kullanici
{
    public partial class KullaniciListeleme : Form
    {
        public SqlCommand sorgu;
        public KullaniciListeleme()
        {
            InitializeComponent();
        }
        private void KullaniciListeleme_Load(object sender, EventArgs e)
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from tbl_kullanicilar", yeniBaglanti.baglanti);

            Listele();

            cbKullaniciAdi.Enabled = false;
            cbAd.Enabled = false;
            cbSoyad.Enabled = false;
            cbBirimId.Enabled = false;
        }
        public void Listele()
        { 
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        } 
        private void btnCikis_Click(object sender, EventArgs e)
        {
            AnaMenu Giris = new AnaMenu();
            Giris.Show();
            this.Close();
        } 
        private void rbTumListe_CheckedChanged(object sender, EventArgs e)
        {
            cbKullaniciAdi.Enabled = false;
            cbAd.Enabled = false;
            cbSoyad.Enabled = false;
            cbBirimId.Enabled = false;
        }
        private void rbSecili_CheckedChanged(object sender, EventArgs e)
        {
            cbKullaniciAdi.Enabled = true;
            cbAd.Enabled = true;
            cbSoyad.Enabled = true;
            cbBirimId.Enabled = true;
        }
        public string secim_kullaniciAdi;
        public string secim_adi;
        public string secim_soyadi;
        public string secim_birimId;

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            if (rbTumListe.Checked == true)
            {
                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from tbl_kullanicilar", yeniBaglanti.baglanti);
                Listele();
            }
            if (rbSecili.Checked == true)
            {
                if (cbKullaniciAdi.Checked == true)
                    secim_kullaniciAdi = "KullaniciAdi,";
                else
                    secim_kullaniciAdi = "";

                if (cbAd.Checked == true)
                    secim_adi = "Ad,";
                else
                    secim_adi = "";

                if (cbSoyad.Checked == true)
                    secim_soyadi = "Soyad,";
                else
                    secim_soyadi = "";

                if (cbBirimId.Checked == true)
                    secim_birimId = "BirimID";
                else
                    secim_birimId = "";

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + secim_kullaniciAdi + secim_adi + secim_soyadi + secim_birimId +
                    " from tbl_kullanicilar", yeniBaglanti.baglanti);
                Listele();
            }
        }
    }
}
