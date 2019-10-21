using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EfCoreDatabasesTest.Models;

namespace EfCoreDatabasesTest.DataAccess
{
    public interface IRepositoryBase<T> where T:class,IEntity,new()
    {
         void Add(T entity);
         void Update(T entity);
         void Delete(T entity);
        Task<List<T>> GetListAsync(Expression<Func<T,bool>> filter);
         Task<T> GetAsync(Expression<Func<T,bool>> filter);
    }
}