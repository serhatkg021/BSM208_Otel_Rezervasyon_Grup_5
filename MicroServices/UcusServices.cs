using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace MicroServices
{
    public class UcusServices
    {
        SqlConnection baglanti;
        public UcusServices()
        {
            baglanti = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bsm208donemprojesigrup5; Integrated Security = True;");
        }
        
        public DataTable ucusListe()
        {
            baglanti.Open();
            string sorguString = "Select * FROM ucuslar";
            SqlDataAdapter da = new SqlDataAdapter(sorguString, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ucusEkle(Ucus u)
        { 
            bool donus = false;
            string sorguString = "INSERT INTO ucuslar (kalkisYeri,inisYeri,havayoluAdi,seferTarihi,aktiflik) Values (@uKalkisYeri , @uInisYeri, @uHavayoluAdi, @uSeferTarih, @uDurum)";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@uKalkisYeri", u.kalkisYeri);
            sorgu.Parameters.AddWithValue("@uInisYeri", u.inisYeri);
            sorgu.Parameters.AddWithValue("@uHavayoluAdi", u.havayoluAdi);
            sorgu.Parameters.AddWithValue("@uSeferTarih", u.seferTarih);
            sorgu.Parameters.AddWithValue("@uDurum", u.durum);
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
