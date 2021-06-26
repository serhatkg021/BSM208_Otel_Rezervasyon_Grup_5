using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using MicroServices;
using System.Collections.Generic;

namespace TestServices
{
    [TestClass]
    public class TestKoltukServices
    {
        KoltukServices servis = new KoltukServices();

        [TestMethod]
        public void koltukKontrol()
        {
            Ucus ucus = new Ucus();
            ucus.id = 1010;

            List<Koltuk> koltuklar = new List<Koltuk>();
            koltuklar = servis.koltukKontrol(ucus);

            bool sonuc = false;
            if (koltuklar.Count == 12)
            {
                sonuc = true;
            }
            Assert.AreEqual(sonuc, true);
        }
    }
}
