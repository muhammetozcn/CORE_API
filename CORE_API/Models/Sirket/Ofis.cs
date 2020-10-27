using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Models.Sirket
{
    public class Ofis:IEntity
    {
        public int OfisId { get; set; }
        public string OfisAd { get; set; }
        public string Lokasyon { get; set; }
        public int Postakodu { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
    }
}
