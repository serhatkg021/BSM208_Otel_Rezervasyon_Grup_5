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

        public bool girisKontrol(Kullanici k)
        {
            bool donus = false; 
            string sorguString = "SELECT * FROM kullanicilar WHERE kullaniciAdi=@kAd AND sifre=@kSifre";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kAd", k.kullaniciAdi);
            sorgu.Parameters.AddWithValue("@kSifre", k.sifre);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            if (cikti.HasRows)
            {
                donus = true;
            }
            baglanti.Close();
            return donus;
        }

        public bool ekle(Kullanici k)
        {
            bool donus = false;
            string sorguString = "INSERT INTO kullanicilar (kullaniciAdi,sifre,dogumTarih,hesapTur,durum) Values (@kAd , @kSifre, @kDogumTarih, @kHesapTur, @kDurum)";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kAd", k.kullaniciAdi);
            sorgu.Parameters.AddWithValue("@kSifre", k.sifre);
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
    }
}
