using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Concrete.Firebase
{
    public class ReadingDal : FireBaseEntityRepositoryBase<Reading>, IReadingDal
    {
        public ReadingDal(string collectionName) : base(collectionName)
        {
        }
        
        //Reading+Meter+User verilerini Dto'ya dönüştür
        public async Task<List<ReadingDetailDto>> GetAllReadingDetailAsync()
        {
            // 1) Readings kolleksiyonu
            var readingsData = await _context.Client
                .Child("Readings")
                .OnceAsync<Reading>();
            // 2) Meters Kolleksiyonu 
            var metersData = await _context.Client
                .Child("Meters")
                .OnceAsync<Meter>();


            // 3)Dto listesi oluştur

            var result = readingsData.Select(r =>
            {
                var reading = r.Object;

                //Meter eşleştirme 

                Meter? meter = metersData
                       .Select(m => m.Object)
                       .FirstOrDefault(m => m.Id == reading.MeterId);

                return new ReadingDetailDto
                {
                    Id = r.Key,
                    TuketimKumulatif = reading.TuketimKumulatif,
                    TuketimAnlik = reading.TuketimAnlik,
                    Gerilim = reading.Gerilim,
                    Akim = reading.Akim,
                    Guc = reading.Guc,
                    ZamanDalgasi = reading.ZamanDalgasi,


                    MeterId = meter?.Id ?? reading.MeterId,
                    MeterNo = meter?.MeterNo ?? string.Empty,
                    MeterModel = meter?.Model ?? string.Empty,
                    AktifMi = meter?.AktifMi ?? true
                };
            }).ToList();

            return result;
        }
    }
}