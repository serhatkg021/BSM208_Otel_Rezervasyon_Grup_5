using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;
using System.Collections.Generic;

namespace TestServices
{
    [TestClass]
    public class TestRezervasyonServices
    {
        RezervasyonServices servis = new RezervasyonServices();
        [TestMethod]
        public void kullaniciRezervasyonListe()
        {
            Kullanici denemeKullanici = new Kullanici();
            denemeKullanici.id = 1;
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            rezervasyonlar = servis.kullaniciRezervasyonListe(denemeKullanici);

            bool sonuc = false;
            if (rezervasyonlar.Count != 0)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
        [TestMethod]
        public void yoneticiRezervasyonListe()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            rezervasyonlar = servis.yoneticiRezervasyonListe();

            bool sonuc = false;
            if (rezervasyonlar.Count != 0)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
    }
}
