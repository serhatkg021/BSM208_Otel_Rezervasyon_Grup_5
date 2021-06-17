using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rezervasyon
    {
        public int id { get; set; }
        public Kullanici kullanici { get; set; }
        public Ucus ucus { get; set; }
        public int koltukNo { get; set; }
        public string acentaAdi { get; set; }
        public decimal biletFiyat { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public Boolean durum { get; set; }
    }
}
