using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBillinngDal:IEntityRepository<Billing>
    {
        //son x fatura listesi
        Task<List<Billing>> GetLastXBillingAsync(string userId, int piece);

        //ödeme ekranı için
        Task<List<Billing>> GetNoPaidBillingAsync(string userId);

        Task<Billing> GetBillingByIdAsync(string billingId);
        //detay sayfası için
    }
}
