using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Arıza 
    public class Alert:IEntity
    {
        public string Id { get; set; }
        public string MeterID { get; set; }
        public string KullaniciID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime BildirimTarihi { get; set; }
        public bool CozulduMu { get; set; }
    }
}
