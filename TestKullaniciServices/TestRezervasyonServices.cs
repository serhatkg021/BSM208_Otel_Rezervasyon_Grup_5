using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;

namespace TestServices
{
    [TestClass]
    public class TestRezervasyonServices
    {
        [TestMethod]
        public void kullaniciRezervasyonListe()
        {
            RezervasyonServices servis = new RezervasyonServices();
            Kullanici denemeKullanici = new Kullanici();
            denemeKullanici.id = 1;

            Rezervasyon donus = servis.kullaniciRezervasyonListe(denemeKullanici);

            bool sonuc = false;
            if (donus != null)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
    }
}
