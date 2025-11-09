using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MeterManager : IMeterService
    {
        public Task AddAsync(Meter meter)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Meter meter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Meter>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Meter>> GetAllMeterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Meter> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Meter> GetByMeterNoAsync(string meterNo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Meter meter)
        {
            throw new NotImplementedException();
        }
    }
}
