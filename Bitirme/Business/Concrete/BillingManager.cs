using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillingManager : IBillingService
    {
        public Task AddAsync(Billing billing)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Billing billing)
        {
            throw new NotImplementedException();
        }

        public Task<List<Billing>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Billing> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Billing> GetByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Billing billing)
        {
            throw new NotImplementedException();
        }
    }
}
