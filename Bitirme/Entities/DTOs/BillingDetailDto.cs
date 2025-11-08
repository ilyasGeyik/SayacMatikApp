using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BillingDetailDto:IDto
    {
        public string Id { get; set; }
        public double ToplamTuketim { get; set; } //kw cinsinden
        public double BirimFiyat { get; set; } // kw başına tl
        public double ToplamTutar { get; set; } //Hesaplanan tl
        public DateTime DonemBaslangic { get; set; }
        public DateTime DonemBitis { get; set; }

        //Meter(Sayaç) Bilgisi
        public string MeterId { get; set; }
        public string MeterNo { get; set; }
        public string MeterModel { get; set; }

        //Kullanici(User) Bilgisi
        public string KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }

        public string Email { get; set; }
    }
}
