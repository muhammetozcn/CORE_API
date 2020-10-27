using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Models.Sirket
{
    public class Departman:IEntity
    {
        public int DepartmanId { get; set; }
        public string DepartmanAd { get; set; }
        public string Yoneticisi { get; set; }
        public string Lokasyon { get; set; }
    }
}
