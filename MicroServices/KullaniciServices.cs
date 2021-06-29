using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Veritabanı için gerekli
using System.Data;
using System.Data.SqlClient;
// Model nesnemiz
using Entities;

namespace MicroServices
{
    public class KullaniciServices
    {
        SqlConnection baglanti;

        public KullaniciServices()
        {
            baglanti = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bsm208donemprojesigrup5; Integrated Security = True;");
        }

        public Kullanici girisKontrol(Kullanici k)
        {
            string sorguString = "SELECT * FROM kullanicilar WHERE kullaniciAdi=@kAd AND sifre=@kSifre";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kAd", k.kullaniciAdi);
            sorgu.Parameters.AddWithValue("@kSifre", k.sifre);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            Kullanici girisYapan = new Kullanici();
            if (cikti.Read())
            {
                girisYapan.id = Convert.ToInt32(cikti["kullaniciID"]);
                girisYapan.kullaniciAdi = Convert.ToString(cikti["kullaniciAdi"]);
                girisYapan.sifre = Convert.ToString(cikti["sifre"]);
                girisYapan.kullaniciAdiSoyadi = Convert.ToString(cikti["kullaniciAdiSoyadi"]);
                girisYapan.dogumTarih = Convert.ToDateTime(cikti["dogumTarihi"]);
                girisYapan.hesapTur = Convert.ToInt32(cikti["hesapTuru"]);
                girisYapan.olusturulmaTarih = Convert.ToDateTime(cikti["olusturmaTarihi"]);
                girisYapan.durum = Convert.ToBoolean(cikti["aktiflik"]);
            }
            else
            {
                girisYapan = null;
            }
            baglanti.Close();
            return girisYapan;
        }

        public bool kullaniciEkle(Kullanici k)
        {
            bool donus = false;
            string sorguString = "INSERT INTO kullanicilar (kullaniciAdi,sifre,kullaniciAdiSoyadi,dogumTarihi,hesapTuru,aktiflik) Values (@kAd , @kSifre, @kAdSoyad ,@kDogumTarih, @kHesapTur, @kDurum)";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kAd", k.kullaniciAdi);
            sorgu.Parameters.AddWithValue("@kSifre", k.sifre);
            sorgu.Parameters.AddWithValue("@kAdSoyad", k.kullaniciAdiSoyadi);
            sorgu.Parameters.AddWithValue("@kDogumTarih", k.dogumTarih);
            sorgu.Parameters.AddWithValue("@kHesapTur", k.hesapTur);
            sorgu.Parameters.AddWithValue("@kDurum", k.durum);
            baglanti.Open();
            int ciktiSayi = sorgu.ExecuteNonQuery(); // İşlemdemden etkilenen kayıt sayısını getirir
            if (ciktiSayi > 0)
            {
                donus = true;
            }
            baglanti.Close();
            return donus;
        }
        public bool kullaniciAdiKontrol(string kAd)     // Sisteme üye olurken kullanıcı adına sahip başka kullanıcı olup olmadığını kontrol eder
        {
            bool donus = true;
            string sorguString = "SELECT kullaniciAdi FROM kullanicilar WHERE kullaniciAdi=@kAd";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kAd", kAd);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            if (cikti.Read())
            {
                donus = false;
            }
            baglanti.Close();
            return donus;
        }
    }
}
