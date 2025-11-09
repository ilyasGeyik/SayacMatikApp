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
    public class AlertDal : FireBaseEntityRepositoryBase<Alert>, IAlertDal
    {
        public AlertDal(string collectionName = "Alerts") : base(collectionName)
        {
        }

        public Task<List<Alert>> GetAlertsByDateAsync(string meterNo, DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetOpenAlertsAsync(string meterNo)
        {
            throw new NotImplementedException();
        }
    }
}
