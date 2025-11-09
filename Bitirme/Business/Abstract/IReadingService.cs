using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReadingService
    {
        Task<List<Reading>> GetAllAsync();
        Task<Reading> GetById(string id);
        Task AddAsync(Reading reading);
        Task UpdateAsync(Reading reading);
        Task DeleteAsync(Reading reading);
        Task<List<Reading>> GetByMeterIdAsync(string meterId);
        //son x okuma verisi,mobil uygulama ekranında kullanılacak=> piece = adet
        Task<List<Reading>> GetLastXReadingAsync(string meterNo, int piece);

        //Tarih aralığında tüketim verisi 
        Task<List<Reading>> GetReadingByDateAsync(string meterNo, DateTime begin, DateTime end);

        //Anlık veri veya en son değer
        Task<Reading> GetLastReadingAsync(string meterNo);
    }
}
