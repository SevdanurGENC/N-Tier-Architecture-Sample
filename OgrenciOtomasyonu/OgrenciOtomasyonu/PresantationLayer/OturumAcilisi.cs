using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OgrenciOtomasyonu.BussinessLogicLayer;
using OgrenciOtomasyonu.PocosLayer;

namespace OgrenciOtomasyonu
{
    public partial class OturumAcilisi : Form
    {
        TblKullanicilarBLL _TblKullanicilarBLL;

        public OturumAcilisi()
        {
            InitializeComponent();
            _TblKullanicilarBLL = new TblKullanicilarBLL();
        }
  
        private void btnGiris_Click(object sender, EventArgs e)
        {

            TblKullanicilarPoco _TblKullaniciGirisiPoco = new TblKullanicilarPoco();
            _TblKullaniciGirisiPoco = _TblKullanicilarBLL.getSorgu(textBox1.Text, textBox2.Text);

            if ((_TblKullaniciGirisiPoco.kullaniciAdi == null) || (_TblKullaniciGirisiPoco.sifre == null))
                MessageBox.Show("Hatali Giris Yaptiniz...");
            else
            {
                this.Hide();
                MessageBox.Show("Hos Geldiniz, " + _TblKullaniciGirisiPoco.kullaniciAdi);
                AnaMenu girisEkrani = new AnaMenu();
                girisEkrani.Show();
            } 
        }
    }
}
