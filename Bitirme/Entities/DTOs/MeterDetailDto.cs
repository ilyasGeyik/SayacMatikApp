using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MeterDetailDto
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public string MeterNo { get; set; }
        public DateTime KurulumTarihi { get; set; }
        public bool AktifMi { get; set; }

        public string KullaniciID { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string Email { get; set; }
    }
}
