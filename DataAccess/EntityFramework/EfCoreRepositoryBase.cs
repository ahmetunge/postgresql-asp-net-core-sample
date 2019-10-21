using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EfCoreDatabasesTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDatabasesTest.DataAccess.EntityFramework
{
    public class EfCoreRepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity, new()
    {
        private readonly DbContext _context;

        public EfCoreRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null)
        {
            var result = filter == null
            ? _context.Set<T>().ToListAsync()
            : _context.Set<T>().Where(filter).ToListAsync();

            return await result;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}