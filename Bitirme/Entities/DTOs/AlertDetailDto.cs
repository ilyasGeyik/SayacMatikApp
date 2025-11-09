using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AlertDetailDto:IDto
    {
        public string Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime BildirimTarihi { get; set; }
        public bool CozulduMu { get; set; }

        //sayaç(meter) bilgileri
        public string MeterId { get; set; }
        public string MeterNo { get; set; }
        public string MeterModel { get; set; }


        //kullanici(user) bilgileri
        
        public string KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string Email { get; set; }


    }
}
