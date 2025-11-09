using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Concrete.Firebase
{
    public class ReadingDal : FireBaseEntityRepositoryBase<Reading>, IReadingDal
    {
        public ReadingDal(string collectionName) : base(collectionName)
        {
        }

        public Task<ReadingDetailDto> GetAllReadingDetailAsync()
        {
            throw new NotImplementedException();
        }
    }
}
