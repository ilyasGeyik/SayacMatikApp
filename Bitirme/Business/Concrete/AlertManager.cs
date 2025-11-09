using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AlertManager : IAlertService
    {
        public Task AddAsync(Alert alert)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Alert alert)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetAlertsByDateAsync(string meterNo, DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Alert> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetOpenAlertsAsync(string meterNo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Alert alert)
        {
            throw new NotImplementedException();
        }
    }
}
