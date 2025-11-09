using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);

        Task<User> GetByEmailAsync(string email);

        //kayıt sırasında e-mail kontrolü
        Task<bool> EmailIsThereAsync(string email);

        //Sistem yöneticisi veya raporlama için aktif kullanıcılar
        Task<List<User>> GetActiveUserAsync();
    }
}
