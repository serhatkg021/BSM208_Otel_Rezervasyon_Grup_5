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
