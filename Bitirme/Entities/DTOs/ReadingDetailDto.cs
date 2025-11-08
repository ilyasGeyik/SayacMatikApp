using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ReadingDetailDto:IDto
    {
        public string Id { get; set; }
        public double TuketimKumulatif { get; set; }//toplam kwh
        public double TuketimAnlik { get; set; }//Anlik tüketim
        public double Gerilim { get; set; }//volt
        public double Akim { get; set; }//Amper
        public double Guc { get; set; }//watt
        public DateTime ZamanDalgasi { get; set; }//Okuma zamanı


        //Meter(Sayaç) bilgisi

        public string MeterId { get; set; }
        public string MeterNo { get; set; }
        public string MeterModel { get; set; }
        public bool AktifMi {  get; set; }
    }
}
