using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Modellere Erişim
using Entities;
//Veri tabanı için Gerekli
using System.Data;
using System.Data.SqlClient;

namespace MicroServices
{
    public class BildirimServices
    {
        SqlConnection baglanti;

        public BildirimServices()
        {
            baglanti = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bsm208donemprojesigrup5; Integrated Security = True;");
        }

        public bool bildirimEkle(Bildirim b)
        {
            bool donus = false;
            string sorguString = "INSERT INTO bildirimler (ucusID,bildirimIcerigi,aktiflik) Values (@uID , @bIcerik , @bDurum)";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@uID", b.ucus.id);
            sorgu.Parameters.AddWithValue("@bIcerik", b.bildirimIcerigi);
            sorgu.Parameters.AddWithValue("@bDurum", b.durum);
            baglanti.Open();
            int ciktiSayi = sorgu.ExecuteNonQuery(); // İşlemdemden etkilenen kayıt sayısını getirir
            if (ciktiSayi > 0)
            {
                donus = true;
            }
            baglanti.Close();
            return donus;
        }
        public List<Bildirim> bildirimKullaniciKontrol(Kullanici k)
        {
            string sorguString = "SELECT b.bildirimlerID, u.ucuslarID, u.havayoluAdi, " +
                "u.kalkisYeri, u.inisYeri, u.seferTarihi, b.bildirimIcerigi, b.aktiflik  " +
                "FROM bildirimler as b " +
                "LEFT JOIN ucuslar as u ON b.ucusID = u.ucuslarID " +
                "LEFT JOIN kullaniciRezervasyon as kr ON b.ucusID = kr.ucusID " +
                "WHERE kr.kullaniciID=@kID";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kID", k.id);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            List<Bildirim> bildirimler = new List<Bildirim>();

            if (cikti.Read())
            {
                Ucus u = new Ucus();
                u.id = Convert.ToInt32(cikti["ucuslarID"]);
                u.havayoluAdi = Convert.ToString(cikti["havayoluAdi"]);
                u.kalkisYeri = Convert.ToString(cikti["kalkisYeri"]);
                u.inisYeri = Convert.ToString(cikti["inisYeri"]);
                u.seferTarih = Convert.ToDateTime(cikti["seferTarihi"]);
                Bildirim bildirim = new Bildirim();
                bildirim.bildirimlerID = Convert.ToInt32(cikti["bildirimlerID"]);
                bildirim.ucus = u;
                bildirim.bildirimIcerigi = Convert.ToString(cikti["bildirimIcerigi"]);
                bildirim.durum = Convert.ToBoolean(cikti["aktiflik"]);
                bildirimler.Add(bildirim);
            }
            cikti.Close();
            baglanti.Close();
            return bildirimler;
        }
    }
}
