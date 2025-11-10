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
    public class AlertDal : FireBaseEntityRepositoryBase<Alert>, IAlertDal
    {
        public AlertDal(string collectionName = "Alerts") : base(collectionName)
        {
        }

        //Alert+Meter+User bilgilerini Dto ya dönüştürür 
        public async Task<List<AlertDetailDto>> GetAllAlertDetailAsync()
        {
            // Alerts Kolleksiyonu 

            var alertsData = await _context.Client
                .Child("Alerts")
                .OnceAsync<Alert>();

            //Meters Kolleksiyonu

            var metersData = await _context.Client
                .Child("Meters")
                .OnceAsync<Meter>();

            //Users Kolleksiyonu

            var usersData = await _context.Client
                .Child("Users")
                .OnceAsync<User>();

            //Dto listesi oluşturma

            var result = alertsData.Select(a =>
            {
                var alert = a.Object;

                //meter eşleştirme

                var meter = metersData
                   .Select(m => m.Object)
                   .FirstOrDefault(m => m.Id == alert.MeterID);

                //user eşleştirme

                var user = usersData
                   .Select(u => u.Object)
                   .FirstOrDefault(u => u.KullaniciID == alert.KullaniciID);

                return new AlertDetailDto
                {
                    Id = a.Key,
                    Baslik = alert.Baslik,
                    Aciklama = alert.Aciklama,
                    BildirimTarihi = alert.BildirimTarihi,
                    CozulduMu = alert.CozulduMu,

                    MeterId = meter?.Id ?? alert.MeterID,
                    MeterNo = meter?.MeterNo ?? string.Empty,
                    MeterModel = meter?.Model ?? string.Empty,

                    KullaniciId = user?.KullaniciID ?? alert.KullaniciID,
                    KullaniciAd = user?.KullaniciAd ?? string.Empty,
                    KullaniciSoyad = user?.KullaniciSoyad ?? string.Empty,
                    Email = user?.Email ?? string.Empty,
                };
            }).ToList();

            return result;
        }
    }
}
