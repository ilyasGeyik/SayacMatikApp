using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IReadingDal:IEntityRepository<Reading>
    {
        //son x okuma verisi,mobil uygulama ekranında kullanılacak=> piece = adet
        Task<List<Reading>> GetLastXReadingAsync(string meterNo, int piece);

        //Tarih aralığında tüketim verisi 
        Task<List<Reading>> GetReadingByDateAsync(string meterNo,DateTime begin,DateTime end);

        //Anlık veri veya en son değer
        Task<Reading> GetLastReadingAsync(string meterNo);

    }
}
