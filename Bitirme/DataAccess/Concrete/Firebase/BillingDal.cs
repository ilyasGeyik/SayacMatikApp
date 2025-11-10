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
    public class BillingDal : FireBaseEntityRepositoryBase<Billing>, IBillingDal
    {
        public BillingDal(string collectionName = "Billings") : base(collectionName)
        {

        }

        public async Task<List<BillingDetailDto>> GetAllBillingDetailAsync()
        {

            //Billings Kolleksiyonu

            var billingsData = await _context.Client
                .Child("Billings")
                .OnceAsync<Billing>();

            //Meters Kolleksiyonu 

            var metersData = await _context.Client
                .Child("Meters")
                .OnceAsync<Meter>();

            //Users Kolleksiyonu

            var usersData = await _context.Client
                .Child("Users")
                .OnceAsync<User>();

            //Dto listesi oluştur

            var result = billingsData.Select(b =>
            {
                var billing = b.Object;

                //Meter eşleştirme 

                var meter = metersData
                    .Select(m => m.Object)
                    .FirstOrDefault(m => m.Id == billing.MeterId);

                //User eşleştirme

                var user = usersData
                     .Select(u => u.Object)
                     .FirstOrDefault(u => u.KullaniciID == billing.KullaniciID);

                return new BillingDetailDto
                {
                    Id = b.Key,
                    ToplamTuketim = billing.ToplamTuketim,
                    BirimFiyat = billing.BirimFiyat,
                    ToplamTutar = billing.ToplamTutar,
                    DonemBaslangic = billing.DonemBaslangic,
                    DonemBitis = billing.DonemBitis,

                    MeterId = meter?.Id ?? billing.MeterId,
                    MeterNo = meter?.MeterNo ?? string.Empty,
                    MeterModel = meter?.Model ?? string.Empty,

                    KullaniciId = user?.KullaniciID ?? billing.KullaniciID,
                    KullaniciAd = user?.KullaniciAd ?? string.Empty,
                    KullaniciSoyad = user?.KullaniciSoyad ?? string.Empty,
                    Email = user?.Email ?? string.Empty
                };
            }).ToList();

            return result;
        }
    }
}
