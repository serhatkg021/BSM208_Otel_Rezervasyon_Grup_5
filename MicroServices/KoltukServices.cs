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
            string sorguString = "SELECT koltukNo, dolulukDurum "+
                                "FROM ucusKoltukDurum " +
                                "WHERE ucusID = @uID";
            SqlCommand sorgu = new SqlCommand(sorguString, baglanti);
            sorgu.Parameters.AddWithValue("@uID" , u.id);
            baglanti.Open();
            SqlDataReader cikti = sorgu.ExecuteReader(); // İşlemdemden etkilenen kayıtları getirir
            List<Koltuk> koltuklar = new List<Koltuk>();
            while (cikti.Read())
            {
                Koltuk koltuk = new Koltuk();
                koltuk.koltukNo = Convert.ToInt32(cikti["koltukNo"]);
                koltuk.koltukDurumu = Convert.ToBoolean(cikti["dolulukDurum"]);
                koltuklar.Add(koltuk);
            }
            baglanti.Close();
            return koltuklar;
        }
    }
}
