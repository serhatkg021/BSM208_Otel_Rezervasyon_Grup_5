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
    public class KoltukServices
    {
        SqlConnection baglanti;
        
        public KoltukServices()
        {
            baglanti = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bsm208donemprojesigrup5; Integrated Security = True;");
        }

        public List<Koltuk> koltukKontrol(Ucus u)
        {
            string sorguString = "SELECT k.koltuklarID, u.ucuslarID, u.havayoluAdi, " +
                "u.kalkisYeri, u.inisYeri, u.seferTarihi, k.koltukDurum ,k.aktiflik  " +
                "FROM koltuklar as k " +
                "LEFT JOIN ucuslar as u ON k.ucusID = u.ucuslarID " +
                "LEFT JOIN kullaniciRezervasyon as kr ON k.ucusID = kr.ucusID " +
                "WHERE k.ucusID=@uID";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@uID" , u.id);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            List<Koltuk> koltuklar = new List<Koltuk>();

            while (cikti.Read())
            {
                Ucus uc = new Ucus();
                uc.id = Convert.ToInt32(cikti["ucuslarID"]);
                uc.havayoluAdi = Convert.ToString(cikti["havayoluAdi"]);
                uc.kalkisYeri = Convert.ToString(cikti["kalkisYeri"]);
                uc.inisYeri = Convert.ToString(cikti["inisYeri"]);
                uc.seferTarih = Convert.ToDateTime(cikti["seferTarihi"]);
                Koltuk koltuk = new Koltuk();
                koltuk.koltuklarID = Convert.ToInt32(cikti["koltuklarID"]);
                koltuk.ucus = uc;
                koltuk.koltukNo = Convert.ToInt32(cikti["koltukNo"]);
                koltuk.koltukDurumu = Convert.ToBoolean(cikti["koltukDurum"]);
                koltuk.durum = Convert.ToBoolean(cikti["aktiflik"]);
                koltuklar.Add(koltuk);
            }
            baglanti.Close();
            return koltuklar;
        }
    }
}
