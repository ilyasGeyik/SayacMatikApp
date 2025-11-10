using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMeterDal:IEntityRepository<Meter>
    {
        Task<List<MeterDetailDto>> GetAllMeterDetailAsync();
    }
}
