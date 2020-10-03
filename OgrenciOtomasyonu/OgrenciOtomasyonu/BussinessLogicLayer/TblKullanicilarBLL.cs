using System;
using System.Data;
using OgrenciOtomasyonu.DataAccessObjects;
using OgrenciOtomasyonu.PocosLayer;


namespace OgrenciOtomasyonu.BussinessLogicLayer
{
    class TblKullanicilarBLL
    {
        private TblKullanicilarDAO _TblKullanicilarDAO; 
        public TblKullanicilarBLL()
        {
            _TblKullanicilarDAO = new TblKullanicilarDAO();
        } 
        public TblKullanicilarPoco getSorgu(string kullaniciadi, string sifre)  //Kullanici giris ekrani icin tasarlanmis bir metoddur.
        {
            TblKullanicilarPoco kullaniciGirisi = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            dataTable = _TblKullanicilarDAO.searchKullaniciAdiveSifre(kullaniciadi, sifre);

            foreach (DataRow dr in dataTable.Rows)
            {
                kullaniciGirisi.kullaniciAdi = dr["kullaniciadi"].ToString();
                kullaniciGirisi.sifre = dr["sifre"].ToString();
            }

            return kullaniciGirisi;
        } 
        public TblKullanicilarPoco kaydetKullanici(string kullaniciid, string tckimlik, string kullaniciadi, string sifre, 
            string ad, string soyad, string birimid)  //Kullanici listesine yeni bir kayit ekleyen metoddur.
        {
            TblKullanicilarPoco kullaniciGirisi = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            _TblKullanicilarDAO.insertKullanici(kullaniciid, tckimlik, kullaniciadi, sifre, ad, soyad, birimid);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["kullaniciid"] = kullaniciGirisi.kullaniciID;
                dr["kullaniciadi"] = kullaniciGirisi.kullaniciAdi;
                dr["sifre"] = kullaniciGirisi.sifre;
                dr["ad"] = kullaniciGirisi.ad;
                dr["soyad"] = kullaniciGirisi.soyad;
                dr["tckimlik"] = kullaniciGirisi.tcKimlik;
                dr["birimid"] = kullaniciGirisi.birimID;
            }

            return kullaniciGirisi;
        } 
        public TblKullanicilarPoco guncelleKullanici(string kullaniciid, string tckimlik, string kullaniciadi, 
            string sifre, string ad, string soyad, string birimid) 
            //Kullanici listesinden secilen bir kaydin bilgilerini guncelleyen metoddur.
        {
            TblKullanicilarPoco kullaniciGirisi = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            _TblKullanicilarDAO.updateKullanici(kullaniciid, tckimlik, kullaniciadi, sifre, ad, soyad, birimid);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["kullaniciadi"] = kullaniciGirisi.kullaniciAdi;
                dr["sifre"] = kullaniciGirisi.sifre;
                dr["ad"] = kullaniciGirisi.ad;
                dr["soyad"] = kullaniciGirisi.soyad;
                dr["tckimlik"] = kullaniciGirisi.tcKimlik;
                dr["birimid"] = kullaniciGirisi.birimID; 
            }

            return kullaniciGirisi;
        } 
        public TblKullanicilarPoco silKullanici(string kullaniciid)   //Kullanici listesinde secilen bir kaydin bilgilerini sistemden tamamen siler.
        {
            TblKullanicilarPoco kullaniciGirisi = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            _TblKullanicilarDAO.deleteKullanici(Convert.ToString(kullaniciid));

            return kullaniciGirisi;
        } 
    }
}
