using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAlertService
    {
        Task<List<Alert>> GetAllAsync();
        Task<Alert> GetByIdAsync(string id);
        Task AddAsync(Alert alert);
        Task UpdateAsync(Alert alert);
        Task DeleteAsync(Alert alert);

        Task<List<Alert>> GetByUserIdAsync(string userId);
    }
}
