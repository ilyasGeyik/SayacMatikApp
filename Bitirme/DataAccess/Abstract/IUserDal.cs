using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        //Giriş için veya kullanıcıya özel veriyi almak için
        Task<User> GetByEmailAsync(string email);

        //kayıt sırasında e-mail kontrolü
        Task<bool> EmailIsThereAsync(string email);

        //Sistem yöneticisi veya raporlama için aktif kullanıcılar
        Task<List<User>> GetActiveUserAsync();
        
    }
}
