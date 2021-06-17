using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;

namespace TestServices
{
    [TestClass]
    public class TestKullaniciServices
    {
        [TestMethod]
        public void loginTest()
        {
            Kullanici denemeKullanici = new Kullanici();
            KullaniciServices servis = new KullaniciServices();

            denemeKullanici.kullaniciAdi = "serhat";
            denemeKullanici.sifre = "serhat";
            bool donus = servis.girisKontrol(denemeKullanici);
            Assert.AreEqual(donus, true);
        }

        [TestMethod]
        public void kullaniciEkle()
        {
            Kullanici denemeKullanici = new Kullanici();
            KullaniciServices servis = new KullaniciServices();

            denemeKullanici.kullaniciAdi = "serhat2";
            denemeKullanici.sifre = "serhat2";
            denemeKullanici.kullaniciAdiSoyadi = "Serhat Kadir Gürleyen";
            denemeKullanici.dogumTarih = Convert.ToDateTime("14.01.1999");
            denemeKullanici.hesapTur = 1;
            denemeKullanici.durum = true;

            bool donus = servis.kullaniciEkle(denemeKullanici);
            Assert.AreEqual(donus, true);
        }
    }
}
