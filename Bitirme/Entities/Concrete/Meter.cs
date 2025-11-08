using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //sayaç
    public class Meter:IEntity
    {
        public string Id { get; set; }
        public string KullaniciID { get; set; }
        public string Model { get; set; }
        public string SeriNo { get; set; }
        public DateTime KurulumTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
