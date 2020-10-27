using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Models
{
    public class Calisan : Kisi,IEntity
    {
        public int CalisanId { get; set; }
        public string Telefon { get; set; }
        public DateTime GirisTarih { get; set; } //İşe giriş tarihi
        public double Maas { get; set; }
        public string Departman { get; set; }
        public string Unvan { get; set; }
        public string Yoneticisi { get; set; }
    }
}
