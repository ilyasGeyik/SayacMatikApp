using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReadingManager : IReadingService
    {
        public Task AddAsync(Reading reading)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Reading reading)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reading>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Reading> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reading>> GetByMeterIdAsync(string meterId)
        {
            throw new NotImplementedException();
        }

        public Task<Reading> GetLastReadingAsync(string meterNo)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reading>> GetLastXReadingAsync(string meterNo, int piece)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reading>> GetReadingByDateAsync(string meterNo, DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Reading reading)
        {
            throw new NotImplementedException();
        }
    }
}
