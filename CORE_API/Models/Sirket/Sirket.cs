using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Models.Sirket
{
    public class Sirket:IEntity
    {
        public List<Ofis> Ofisler { get; set; } = new List<Ofis>();
        public List<Departman> Departmanlar { get; set; } = new List<Departman>();

         

    }
}
