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

namespace DataAccess.Concrete.Firebase
{
    public class MeterDal : FireBaseEntityRepositoryBase<Meter>, IMeterDal
    {
        public MeterDal(string collectionName = "Meters") : base(collectionName)
        {
        }

        public async Task<List<MeterDetailDto>> GetAllMeterDetailAsync()
        {
            //Meters kolleksiyonu

            var metersData = await _context.Client
                 .Child("Meters")
                 .OnceAsync<Meter>();

            //User Kolleksiyonu 

            var usersData = await _context.Client
                 .Child("Users")
                 .OnceAsync<User>();

            //Dto listesi oluşturma 

            var result = metersData.Select(m =>
            {
                var meter = m.Object;

                //user eşleştirme

                User? user = usersData
                       .Select(u => u.Object)
                       .FirstOrDefault(u => u.KullaniciID == meter.KullaniciID);

                return new MeterDetailDto
                {
                    Id = m.Key,
                    Model = meter.Model,
                    MeterNo = meter.MeterNo,
                    KurulumTarihi = meter.KurulumTarihi,
                    AktifMi = meter.AktifMi,

                    KullaniciID = user?.KullaniciID ?? meter.KullaniciID,
                    KullaniciAd = user?.KullaniciAd ?? string.Empty,
                    KullaniciSoyad = user?.KullaniciSoyad ?? string.Empty,
                    Email = user?.Email ?? string.Empty

                };
            }).ToList();

            return result;
        }
    }
}
