using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMeterService
    {
        Task<List<Meter>> GetAllAsync();
        Task<Meter> GetByIdAsync(string id);

        Task AddAsync(Meter meter);
        Task UpdateAsync(Meter meter);
        Task DeleteAsync(Meter meter);
        //sayaç numarasına göre sayaç çekmek
        Task<Meter> GetByMeterNoAsync(string meterNo);

        //Admin veya toplu veri kontrolü
        Task<List<Meter>> GetAllMeterAsync();
    }
}
