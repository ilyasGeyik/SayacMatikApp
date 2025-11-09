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
    public class MeterDal : FireBaseEntityRepositoryBase<Meter>, IMeterDal
    {
        public MeterDal(string collectionName = "Meters") : base(collectionName)
        {
        }

        public Task<List<Meter>> GetAllMeterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Meter> GetByMeterNoAsync(string meterNo)
        {
            throw new NotImplementedException();
        }
    }
}
