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
    }
}
