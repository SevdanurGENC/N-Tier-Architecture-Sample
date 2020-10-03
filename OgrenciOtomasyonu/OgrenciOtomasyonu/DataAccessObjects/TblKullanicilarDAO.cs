using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;

namespace OgrenciOtomasyonu.DataAccessObjects
{
    class TblKullanicilarDAO
    { 
        private VeriTabaniBaglantisi baglanti; 
        public TblKullanicilarDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        } 
        public DataTable searchKullaniciAdiveSifre(string kullaniciadi, string sifre)   //Kullanici giris ekrani icin tasarlanmis bir metoddur.
        {
            string sorgu = string.Format("Select * from tbl_kullanicilar where KullaniciAdi = @KullaniciAdi and Sifre=@Sifre");
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciadi);
            sqlParameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sifre);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }
        public bool insertKullanici(string kullaniciid, string tckimlik, string kullaniciadi, 
            string sifre, string ad, string soyad, string birimid)   //Sisteme yeni bir kullanici eklemek icin kullanilan bir metoddur.
        {
            string sorgu = string.Format("insert into tbl_kullanicilar(KullaniciID,TcKimlik,KullaniciAdi,Sifre,Ad,Soyad,BirimID) values(@KullaniciID,@TcKimlik,@KullaniciAdi,@Sifre,@Ad,@Soyad,@BirimID)");

            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciadi);
            sqlParameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sifre);
            sqlParameters[2] = new SqlParameter("@Ad", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ad);
            sqlParameters[3] = new SqlParameter("@Soyad", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(soyad);
            sqlParameters[4] = new SqlParameter("@KullaniciID", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(kullaniciid); 
            sqlParameters[5] = new SqlParameter("@TcKimlik", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(tckimlik);
            sqlParameters[6] = new SqlParameter("@BirimID", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(birimid); 

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }
        public bool updateKullanici(string kullaniciid, string tckimlik, string kullaniciadi, 
            string sifre, string ad, string soyad, string birimid)  //sistemdeki secilen bir kullanicinin bilgilerini guncelleyen metoddur.
        {
            string sorgu = string.Format("update tbl_kullanicilar set KullaniciAdi = @KullaniciAdi, TcKimlik = @TcKimlik, Sifre = @Sifre, Ad = @Ad, Soyad = @Soyad, BirimID = @BirimID where KullaniciID = '" + kullaniciid + "'");

            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(sifre);
            sqlParameters[1] = new SqlParameter("@Ad", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ad);
            sqlParameters[2] = new SqlParameter("@Soyad", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(soyad);
            sqlParameters[3] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kullaniciadi);
            sqlParameters[4] = new SqlParameter("@TcKimlik", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(tckimlik);
            sqlParameters[5] = new SqlParameter("@BirimID", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(birimid);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }
        public bool deleteKullanici(string kullaniciid) //sistemden secilen kullaniciyi silen metoddur..
        {
            string sorgu = string.Format("Delete from tbl_kullanicilar where KullaniciID = '" + kullaniciid + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }  
    }
}
