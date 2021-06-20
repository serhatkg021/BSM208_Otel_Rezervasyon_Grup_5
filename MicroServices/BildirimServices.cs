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

    }
}
