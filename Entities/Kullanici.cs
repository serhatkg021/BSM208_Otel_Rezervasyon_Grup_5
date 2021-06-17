using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kullanici
    {
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string kullaniciAdiSoyadi { get; set; }
        public DateTime dogumTarih { get; set; }
        public int hesapTur { get; set; }
        public DateTime olusturulmaTarih { get; set; }
        public Boolean durum { get; set; }
    }
}
