using OgrenciOtomasyonu.BussinessLogicLayer;
using OgrenciOtomasyonu.PocosLayer;
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
    public partial class KullaniciKayitSilme : Form
    {
        private TblKullanicilarBLL _TblKullanicilarBLL;
        public KullaniciKayitSilme()
        {
            InitializeComponent();
            _TblKullanicilarBLL = new TblKullanicilarBLL();
        } 
        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();

            SqlCommand sorgu = new SqlCommand("Select * from tbl_kullanicilar", yeniBaglanti.baglanti);

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
        private void btnSil_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco kullanicilar = new TblKullanicilarPoco();
            kullanicilar = _TblKullanicilarBLL.silKullanici(txtId.Text);
            MessageBox.Show("Silme Islemi Tamamlanmistir..."); 
            Listele();
        } 
        private void KullaniciKayitSilme_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTcKimlik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBirimId.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
