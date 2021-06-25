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
        public List<Ucus> ucusListeYonetici()
        {
            string sorguString = "Select ucuslarID, havayoluAdi, kalkisYeri, inisYeri, seferTarihi FROM ucuslar";
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            List<Ucus> ucuslar = new List<Ucus>();
            while (cikti.Read())
            {
                Ucus u = new Ucus();
                u.id = Convert.ToInt32(cikti["ucuslarID"]);
                u.havayoluAdi = Convert.ToString(cikti["havayoluAdi"]);
                u.kalkisYeri = Convert.ToString(cikti["kalkisYeri"]);
                u.inisYeri = Convert.ToString(cikti["inisYeri"]);
                u.seferTarih = Convert.ToDateTime(cikti["seferTarihi"]);
                ucuslar.Add(u);
            }
            baglanti.Close();
            return ucuslar;
        }

        public DataTable ucusListe(Ucus u)
        {
            string[] sorguString = new string[3];
            sorguString[0] = "Select u.ucuslarID, a1.acentaAdi, u.havayoluAdi, u.kalkisYeri, u.inisYeri, u.seferTarihi, a1.biletFiyat FROM ucuslar as u " +
                                    "INNER JOIN acenta1Bilet as a1 ON u.ucuslarID = a1.ucusID " +
                                    "WHERE kalkisYeri=@kYeri " +
                                    "AND inisYeri =@iYeri " +
                                    "AND seferTarihi=@sTarih " +
                                    "AND havayoluAdi=@hAdi";

            sorguString[1] = "Select u.ucuslarID, a2.acentaAdi, u.havayoluAdi, u.kalkisYeri, u.inisYeri, u.seferTarihi, a2.biletFiyat FROM ucuslar as u " +
                                    "INNER JOIN acenta2Bilet as a2 ON u.ucuslarID = a2.ucusID " +
                                    "WHERE kalkisYeri=@kYeri " +
                                    "AND inisYeri =@iYeri " +
                                    "AND seferTarihi=@sTarih " +
                                    "AND havayoluAdi=@hAdi";

            sorguString[2] = "Select u.ucuslarID, a3.acentaAdi, u.havayoluAdi, u.kalkisYeri, u.inisYeri, u.seferTarihi, a3.biletFiyat FROM ucuslar as u " +
                                    "INNER JOIN acenta3Bilet as a3 ON u.ucuslarID = a3.ucusID " +
                                    "WHERE kalkisYeri=@kYeri " +
                                    "AND inisYeri =@iYeri " +
                                    "AND seferTarihi=@sTarih " +
                                    "AND havayoluAdi=@hAdi";

            baglanti.Open();
            DataTable dt = new DataTable();
            for (int i = 0; i < 3; i++)
            {
                SqlCommand sorgu = new SqlCommand(sorguString[i], baglanti);
                sorgu.Parameters.AddWithValue("@kYeri", u.kalkisYeri);
                sorgu.Parameters.AddWithValue("@iYeri", u.inisYeri);
                sorgu.Parameters.AddWithValue("@sTarih", u.seferTarih);
                sorgu.Parameters.AddWithValue("@hAdi", u.havayoluAdi);
                SqlDataAdapter da = new SqlDataAdapter(sorgu);
                da.Fill(dt);
            }
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
