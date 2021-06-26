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
            string sorguUcusString = "INSERT INTO ucuslar (kalkisYeri,inisYeri,havayoluAdi,seferTarihi,aktiflik) Values (@uKalkisYeri , @uInisYeri, @uHavayoluAdi, @uSeferTarih, @uDurum)";
            SqlCommand sorguUcus = new SqlCommand(sorguUcusString, baglanti);
            sorguUcus.Parameters.AddWithValue("@uKalkisYeri", u.kalkisYeri);
            sorguUcus.Parameters.AddWithValue("@uInisYeri", u.inisYeri);
            sorguUcus.Parameters.AddWithValue("@uHavayoluAdi", u.havayoluAdi);
            sorguUcus.Parameters.AddWithValue("@uSeferTarih", u.seferTarih);
            sorguUcus.Parameters.AddWithValue("@uDurum", u.durum);
            baglanti.Open();
            int ciktiSayi = sorguUcus.ExecuteNonQuery(); // İşlemdemden etkilenen kayıt sayısını getirir
            if (ciktiSayi > 0)
            {
                string sorguUcusIDString = "Select ucuslarID FROM ucuslar " +
                                        "WHERE kalkisYeri= @uKalkisYeri " +
                                        "AND inisYeri = @uInisYeri " +
                                        "AND havayoluAdi= @uHavayoluAdi " +
                                        "AND seferTarihi= @uSeferTarih " +
                                        "AND aktiflik= @uDurum ";
                SqlCommand sorguUcusID = new SqlCommand(sorguUcusIDString, baglanti);
                sorguUcusID.Parameters.AddWithValue("@uKalkisYeri", u.kalkisYeri);
                sorguUcusID.Parameters.AddWithValue("@uInisYeri", u.inisYeri);
                sorguUcusID.Parameters.AddWithValue("@uHavayoluAdi", u.havayoluAdi);
                sorguUcusID.Parameters.AddWithValue("@uSeferTarih", u.seferTarih);
                sorguUcusID.Parameters.AddWithValue("@uDurum", u.durum);
                SqlDataReader ciktiUcusID = sorguUcusID.ExecuteReader();
                ciktiUcusID.Read();
                int ucusID = Convert.ToInt32(ciktiUcusID["ucuslarID"]);
                ciktiUcusID.Close();

                string sorguKoltukString = "INSERT INTO ucusKoltukDurum (ucusID,koltukNo,dolulukDurum,aktiflik) Values (@kUID , @kNO, @kKoltukDurum, @kDurum)";
                for (int i = 1; i <= 12; i++)
                {
                    SqlCommand sorguKoltuk = new SqlCommand(sorguKoltukString, baglanti);
                    sorguKoltuk.Parameters.AddWithValue("@kUID", ucusID);
                    sorguKoltuk.Parameters.AddWithValue("@kNO", i);
                    sorguKoltuk.Parameters.AddWithValue("@kKoltukDurum", false);
                    sorguKoltuk.Parameters.AddWithValue("@kDurum", u.durum);
                    sorguKoltuk.ExecuteNonQuery();
                }
                donus = true;
            }
            baglanti.Close();
            return donus;
        }
    }
}
