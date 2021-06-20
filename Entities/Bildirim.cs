using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bildirim
    {
        public int bildirimlerID { get; set; }
        public Ucus ucus { get; set; }
        public string bildirimIcerigi { get; set; }
        public Boolean durum { get; set; }
    }
}
