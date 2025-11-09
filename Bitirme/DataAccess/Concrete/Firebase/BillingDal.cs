using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public Task<Billing> GetBillingByIdAsync(string billingId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Billing>> GetLastXBillingAsync(string userId, int piece)
        {
            throw new NotImplementedException();
        }

        public Task<List<Billing>> GetNoPaidBillingAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
