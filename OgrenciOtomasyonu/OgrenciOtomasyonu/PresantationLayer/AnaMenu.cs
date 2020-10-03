using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
           
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void yeniKayitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            KullaniciYeniKayit yeniKayit = new KullaniciYeniKayit();
            yeniKayit.Show();
            this.Close();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void kayitSilmeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciKayitSilme sil = new Kullanici.KullaniciKayitSilme();
            sil.Show();
            this.Close();
        }

        private void listelemeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciListeleme listele = new Kullanici.KullaniciListeleme();
            listele.Show();
            this.Close();
        }

        private void guncellemeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PresantationLayer.Kullanici.KullaniciGuncelleme guncelleme = new PresantationLayer.Kullanici.KullaniciGuncelleme();
            guncelleme.Show();
            this.Close();
            
        }
    }
}
