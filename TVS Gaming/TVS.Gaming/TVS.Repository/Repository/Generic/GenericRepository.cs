using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TVS.Data.Models;

namespace TVS.Repository.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly TVSMAZTCASDBUAT03Context _tvsDbContext;
        private readonly DbSet<T> table = null;
        public GenericRepository()
        {
            this._tvsDbContext = new TVSMAZTCASDBUAT03Context();
            table = _tvsDbContext.Set<T>();
        }
        public GenericRepository(TVSMAZTCASDBUAT03Context tvsDbContext)
        {
            this._tvsDbContext = tvsDbContext;
            table = _tvsDbContext.Set<T>();
        }
        public async Task<List<T>> GetAll()
        {
            return await (Task<List<T>>)table.ToListAsync();
        }
        public async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public async Task<T> Insert(T obj)
        {
            await table.AddAsync(obj);
            return obj;
        }
        public async Task<T> Update(T obj)
        {
            _tvsDbContext.Entry(obj).State = EntityState.Modified;
            await _tvsDbContext.SaveChangesAsync();
            return obj;
        }
        public async Task Delete(object id)
        {
            T existing = await table.FindAsync(id);
            table.Remove(existing);
        }
        public async Task Save()
        {
            await _tvsDbContext.SaveChangesAsync();
        }
    }
}
