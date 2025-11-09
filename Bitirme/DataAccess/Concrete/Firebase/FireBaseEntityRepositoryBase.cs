using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using DataAccess.Concrete.Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete
{
    public class FireBaseEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly FirebaseContext _context;
        protected readonly string _collectionName;
        public FireBaseEntityRepositoryBase(string collectionName)
        {
            _context = new FirebaseContext();
            _collectionName = collectionName;
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _context.Client
                 .Child(_collectionName)
                 .PostAsync(entity);
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            var allData = await _context.Client
                .Child(_collectionName)
                .OnceAsync<TEntity>();

            var item = allData.FirstOrDefault(d => d.Object.Equals(entity));

            if(item != null)
            {
                await _context.Client
                    .Child(_collectionName)
                    .Child(item.Key)
                    .DeleteAsync();
            }
        }
        public virtual async Task UpdateAsync(TEntity entity)
        {
            var allData = await _context.Client
                .Child(_collectionName)
                .OnceAsync<TEntity>();
            var item = allData.FirstOrDefault(d => d.Object.Equals(entity));

            if(item != null)
            {
                await _context.Client
                   .Child(_collectionName)
                   .Child(item.Key)
                   .PutAsync(entity);
            }
        }
        public virtual async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            var data = await _context.Client
                .Child(_collectionName)
                .OnceAsync<TEntity>();

            var list = data.Select(d => d.Object).ToList();

            if(filter != null)
            {
                list = list.AsQueryable().Where(filter).ToList();
            }

            return list;


        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            var all = await GetAllAsync(filter);
            return all.FirstOrDefault();
        }
   
    }
}
