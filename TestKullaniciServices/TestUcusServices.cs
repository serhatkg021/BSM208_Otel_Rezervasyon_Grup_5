using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;
using System.Data;
using System.Collections.Generic;

namespace TestServices
{
    [TestClass]
    public class TestUcusServices
    {
        UcusServices servis = new UcusServices();

        [TestMethod]
        public void ucusEkle()
        {
            Ucus denemeUcus = new Ucus();
            denemeUcus.havayoluAdi = "ONUR AİR";
            denemeUcus.kalkisYeri = "İstanbul Havalimanı";
            denemeUcus.inisYeri = "Ankara Esenboğa Havalimanı";
            denemeUcus.seferTarih = Convert.ToDateTime("26.06.2021 20:00:00");
            denemeUcus.durum = true;

            bool donus = servis.ucusEkle(denemeUcus);
            Assert.AreEqual(donus, true);
        }
        
        [TestMethod]
        public void ucusListe()
        {
            Ucus arananUcus = new Ucus();
            arananUcus.kalkisYeri = "İstanbul Havalimanı";
            arananUcus.inisYeri = "Ankara Esenboğa Havalimanı";
            arananUcus.seferTarih = Convert.ToDateTime("18.06.2021 18:30");
            arananUcus.havayoluAdi = "PEGASUS";
            DataTable dt = servis.ucusListe(arananUcus);
            bool sonuc = false;
            if (dt != null && dt.Rows.Count > 0)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
        [TestMethod]
        public void ucusListeYonetici()
        {
            List<Ucus> ucuslar = new List<Ucus>();

            ucuslar = servis.ucusListeYonetici();
            bool sonuc = false;
            if (ucuslar.Count != 0)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
    }
}
