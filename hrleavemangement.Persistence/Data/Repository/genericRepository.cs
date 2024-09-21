using hrleavemanagement.application.presistance.contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemangement.Persistence.Data.Repository
{
    public class genericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly hrleaveManagementDb _db;

        public genericRepository(hrleaveManagementDb db)
        {
            _db = db;
        }
        public async Task<T> Add(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
           var any=await _db.Set<T>().FindAsync(id);
            _db.Set<T>().Remove(any);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity=await Get(id);
            return entity!=null;
        }

        public async Task<T> Get(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
