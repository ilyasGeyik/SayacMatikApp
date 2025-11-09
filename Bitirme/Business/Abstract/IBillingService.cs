using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillingService
    {
        Task<List<Billing>> GetAllAsync();
        Task<Billing> GetByIdAsync(string id);
        Task AddAsync(Billing billing);
        Task UpdateAsync(Billing billing);
        Task DeleteAsync(Billing billing);

        Task<Billing> GetByUserIdAsync(string userId);

        //son x fatura listesi
        Task<List<Billing>> GetLastXBillingAsync(string userId, int piece);

        //ödeme ekranı için
        Task<List<Billing>> GetNoPaidBillingAsync(string userId);

        Task<Billing> GetBillingByIdAsync(string billingId);
        //detay sayfası için
    }
}
