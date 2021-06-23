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

        public DataTable ucusListe(Ucus u)
        {
            string sorguString = "Select * FROM ucuslar " +
                                    "WHERE kalkisYeri=@kYeri " +
                                    "AND inisYeri =@iYeri " +
                                    "AND seferTarihi=@sTarih " +
                                    "AND havayoluAdi=@hAdi";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@kYeri", u.kalkisYeri);
            sorgu.Parameters.AddWithValue("@iYeri", u.inisYeri);
            sorgu.Parameters.AddWithValue("@sTarih", u.seferTarih);
            sorgu.Parameters.AddWithValue("@hAdi", u.havayoluAdi);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
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
