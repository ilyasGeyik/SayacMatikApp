using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAlertDal:IEntityRepository<Alert>
    {
        Task<List<Alert>> GetOpenAlertsAsync(string meterNo);
        //hala çözülmemiş arızalar

        Task<List<Alert>> GetAlertsByDateAsync(string meterNo, DateTime begin, DateTime end);
        //tarih aralığını filtreleme
    }
}
