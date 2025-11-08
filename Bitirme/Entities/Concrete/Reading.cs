using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //sayaçtan gelen her veriyi okuma 
    public class Reading:IEntity
    {
        public string Id { get; set; }
        public string MeterId  { get; set; }
        public double TuketimKumulatif { get; set; }//toplam kwh
        public double TuketimAnlik { get; set; }//Anlik tüketim
        public double Gerilim { get; set; }//volt
        public double Akim { get; set; }//Amper
        public double Guc { get; set; }//watt
        public DateTime ZamanDalgasi { get; set; }//Okuma zamanı


    }
}
