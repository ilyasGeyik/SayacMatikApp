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
    public class ReadingDal : FireBaseEntityRepositoryBase<Reading>, IReadingDal
    {
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
    }
}
