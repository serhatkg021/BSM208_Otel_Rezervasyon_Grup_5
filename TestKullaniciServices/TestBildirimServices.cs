using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;

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
            denemeUcus.id = 1;
            denemeBildirim.ucus = denemeUcus;
            denemeBildirim.bildirimIcerigi = "Uçak rötar dolasıyla 15 dk geç kalkacaktır.";
            denemeBildirim.durum = true;

            bool donus = servis.bildirimEkle(denemeBildirim);
            Assert.AreEqual(donus, true);
        }
    }
}
