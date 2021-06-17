using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;

namespace TestServices
{
    [TestClass]
    public class TestUcusServices
    {
        [TestMethod]
        public void ucusEkle()
        {
            Ucus denemeUcus = new Ucus();
            UcusServices servis = new UcusServices();

            denemeUcus.havayoluAdi = "PEGASUS";
            denemeUcus.kalkisYeri = "İstanbul Havalimanı";
            denemeUcus.inisYeri = "Ankara Esenboğa Havalimanı";
            denemeUcus.seferTarih = Convert.ToDateTime("18.06.2021 18:30:00");
            denemeUcus.durum = true;

            bool donus = servis.ucusEkle(denemeUcus);
            Assert.AreEqual(donus, true);
        }
    }
}
