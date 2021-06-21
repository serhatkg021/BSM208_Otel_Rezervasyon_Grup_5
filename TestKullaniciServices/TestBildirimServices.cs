using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;
using System.Collections.Generic;

namespace TestServices
{
    [TestClass]
    public class TestBildirimServices
    {
        BildirimServices servis = new BildirimServices();
        [TestMethod]
        public void bildirimEkle()
        {
            Bildirim denemeBildirim = new Bildirim();
            Ucus denemeUcus = new Ucus();
            denemeUcus.id = 2;
            denemeBildirim.ucus = denemeUcus;
            denemeBildirim.bildirimIcerigi = "Uçak rötar dolasıyla 15 dk geç kalkacaktır.";
            denemeBildirim.durum = true;

            bool donus = servis.bildirimEkle(denemeBildirim);
            Assert.AreEqual(donus, true);
        }

        [TestMethod]
        public void bildirimKullaniciKontrol()
        {
            Kullanici denemeKullanici = new Kullanici();
            denemeKullanici.id = 1;
            List<Bildirim> bildirimler = new List<Bildirim>();

            bildirimler = servis.bildirimKullaniciKontrol(denemeKullanici);

            bool sonuc = false;
            if (bildirimler.Count != 0)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
    }
}
