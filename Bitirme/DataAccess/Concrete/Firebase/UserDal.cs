using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Firebase
{
    public class UserDal : FireBaseEntityRepositoryBase<User>, IUserDal
    {
        public Task<bool> EmailIsThereAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetActiveUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
