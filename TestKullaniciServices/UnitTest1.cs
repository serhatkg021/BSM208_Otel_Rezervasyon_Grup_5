using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;

namespace TestKullaniciServices
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void loginTest()
        {
            Kullanici deneme = new Kullanici();
            KullaniciServices servis = new KullaniciServices();

            deneme.kullaniciAdi = "serhat";
            deneme.sifre = "serhat";
            bool donus = servis.girisKontrol(deneme);
            Assert.AreEqual(donus, true);
        }

        [TestMethod]
        public void kullaniciEkleTest()
        {
            Kullanici deneme = new Kullanici();
            KullaniciServices servis = new KullaniciServices();

            deneme.kullaniciAdi = "serhat4";
            deneme.sifre = "serhat4";
            deneme.dogumTarih = Convert.ToDateTime("14.01.1999");
            deneme.hesapTur = 1;
            deneme.durum = true;

            bool donus = servis.ekle(deneme);
            Assert.AreEqual(donus, true);
        }
    }
}
