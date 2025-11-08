using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Billing:IEntity
    {
        public string Id {  get; set; }
        public string KullaniciID { get; set; } //Faturayı gören kullanıcı
        public string MeterId { get; set; } //Hangi sayaca ait
        public double ToplamTuketim { get; set; } //kw cinsinden
        public double BirimFiyat { get; set; } // kw başına tl
        public double ToplamTutar { get; set; } //Hesaplanan tl
        public DateTime DonemBaslangic { get; set; }
        public DateTime DonemBitis { get; set; }


    }
}
