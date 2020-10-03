using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyonu.PocosLayer
{
   public class TblKullanicilarPoco
    {
        private string _kullaniciID { get; set; }
        private string _tcKimlik { get; set; }
        private string _kullaniciAdi { get; set; }
        private string _sifre { get; set; }
        private string _ad { get; set; }
        private string _soyad { get; set; }
        private string _birimID { get; set; }
        public TblKullanicilarPoco()
        {

        }

        public string kullaniciID
        {
            get
            {
                return _kullaniciID;
            }

            set
            {
                _kullaniciID = value;
            }
        }
        public string tcKimlik
        {
            get
            {
                return _tcKimlik;
            }

            set
            {
                _tcKimlik = value;
            }
        }
        public string kullaniciAdi
        {
            get
            {
                return _kullaniciAdi;
            }

            set
            {
                _kullaniciAdi = value;
            }
        }
        public string sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        }
        public string ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }
        public string soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }
        public string birimID
        {
            get
            {
                return _birimID;
            }

            set
            {
                _birimID = value;
            }
        }
     
    }
}
