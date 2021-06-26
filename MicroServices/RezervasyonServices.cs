using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Veritabanı için gerekli
using System.Data;
using System.Data.SqlClient;
//Modellere erişim
using Entities;

namespace MicroServices
{
    public class RezervasyonServices
    {
        SqlConnection baglanti;
        public RezervasyonServices()
        {
            baglanti = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bsm208donemprojesigrup5; Integrated Security = True;");
        }

        public bool kullaniciRezervasyonEkle(Rezervasyon r)
        {
            bool donus = false;
            string sorguString = "INSERT INTO kullaniciRezervasyon (kullaniciID,ucusID,koltukNo,acentaAdi,biletFiyati,aktiflik) Values (@kID , @uID , @koltukNO ,@aAdi, @bFiyat, @rDurum)";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kID", r.kullanici.id);
            sorgu.Parameters.AddWithValue("@uID", r.ucus.id );
            sorgu.Parameters.AddWithValue("@koltukNO", r.koltukNo);
            sorgu.Parameters.AddWithValue("@aAdi", r.acentaAdi);
            sorgu.Parameters.AddWithValue("@bFiyat", r.biletFiyat);
            sorgu.Parameters.AddWithValue("@rDurum", r.durum);
            baglanti.Open();
            int ciktiSayi = sorgu.ExecuteNonQuery(); // İşlemdemden etkilenen kayıt sayısını getirir
            if (ciktiSayi > 0)
            {
                string sorguUpdateString = "UPDATE ucusKoltukDurum " +
                                            "SET dolulukDurum = @dDurum " +
                                            "WHERE ucusID = @uID AND koltukNo = @kNo";
                SqlCommand sorguUpdate = new SqlCommand(sorguUpdateString, baglanti);
                sorguUpdate.Parameters.AddWithValue("@dDurum", true);
                sorguUpdate.Parameters.AddWithValue("@uID", r.ucus.id);
                sorguUpdate.Parameters.AddWithValue("@kNo", r.koltukNo);
                sorguUpdate.ExecuteNonQuery();
                donus = true;
            }
            baglanti.Close();
            return donus;
        }

        public List<Rezervasyon> kullaniciRezervasyonListe(Kullanici k)
        {
            string sorguString = "SELECT kr.kullaniciRezervasyonID, kr.acentaAdi, k.kullaniciID, k.kullaniciAdiSoyadi," +
                "u.ucuslarID, u.havayoluAdi, u.kalkisYeri, u.inisYeri, u.seferTarihi," +
                "kr.koltukNo, kr.biletFiyati , kr.olusturmaTarih FROM kullaniciRezervasyon as kr " +
                "LEFT JOIN kullanicilar as k ON kr.kullaniciID = k.kullaniciID " +
                "LEFT JOIN ucuslar as u ON kr.ucusID = u.ucuslarID " +
                "WHERE kr.kullaniciID=@kID";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kID", k.id);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            while (cikti.Read())
            {
                Rezervasyon kr = new Rezervasyon();
                kr.id = Convert.ToInt32(cikti["kullaniciRezervasyonID"]);
                kr.acentaAdi = Convert.ToString(cikti["acentaAdi"]);
                Kullanici rk = new Kullanici();
                Ucus u = new Ucus();
                rk.id = Convert.ToInt32(cikti["kullaniciID"]);
                rk.kullaniciAdiSoyadi = Convert.ToString(cikti["kullaniciAdiSoyadi"]);
                u.id = Convert.ToInt32(cikti["ucuslarID"]);
                u.havayoluAdi = Convert.ToString(cikti["havayoluAdi"]);
                u.kalkisYeri = Convert.ToString(cikti["kalkisYeri"]);
                u.inisYeri = Convert.ToString(cikti["inisYeri"]);
                u.seferTarih = Convert.ToDateTime(cikti["seferTarihi"]);
                kr.ucus = u;
                kr.kullanici = rk;
                kr.koltukNo = Convert.ToInt32(cikti["koltukNo"]);
                kr.biletFiyat = Convert.ToDecimal(cikti["biletFiyati"]);
                kr.olusturmaTarih = Convert.ToDateTime(cikti["olusturmaTarih"]);
                rezervasyonlar.Add(kr);
            }
            baglanti.Close();
            return rezervasyonlar;
        }
        public List<Rezervasyon> yoneticiRezervasyonListe()
        {
            string sorguString = "SELECT kr.kullaniciRezervasyonID, kr.acentaAdi, k.kullaniciID, k.kullaniciAdiSoyadi," +
                "u.ucuslarID, u.havayoluAdi, u.kalkisYeri, u.inisYeri, u.seferTarihi," +
                "kr.koltukNo, kr.biletFiyati , kr.olusturmaTarih FROM kullaniciRezervasyon as kr " +
                "LEFT JOIN kullanicilar as k ON kr.kullaniciID = k.kullaniciID " +
                "LEFT JOIN ucuslar as u ON kr.ucusID = u.ucuslarID";

            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            while (cikti.Read())
            {
                Rezervasyon kr = new Rezervasyon();
                kr.id = Convert.ToInt32(cikti["kullaniciRezervasyonID"]);
                kr.acentaAdi = Convert.ToString(cikti["acentaAdi"]);
                Kullanici rk = new Kullanici();
                Ucus u = new Ucus();
                rk.id = Convert.ToInt32(cikti["kullaniciID"]);
                rk.kullaniciAdiSoyadi = Convert.ToString(cikti["kullaniciAdiSoyadi"]);
                u.id = Convert.ToInt32(cikti["ucuslarID"]);
                u.havayoluAdi = Convert.ToString(cikti["havayoluAdi"]);
                u.kalkisYeri = Convert.ToString(cikti["kalkisYeri"]);
                u.inisYeri = Convert.ToString(cikti["inisYeri"]);
                u.seferTarih = Convert.ToDateTime(cikti["seferTarihi"]);
                kr.ucus = u;
                kr.kullanici = rk;
                kr.koltukNo = Convert.ToInt32(cikti["koltukNo"]);
                kr.biletFiyat = Convert.ToDecimal(cikti["biletFiyati"]);
                kr.olusturmaTarih = Convert.ToDateTime(cikti["olusturmaTarih"]);
                rezervasyonlar.Add(kr);
            }
            baglanti.Close();
            return rezervasyonlar;
        }
    }
}
