using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepositoryBase<T> where T:class,IEntity,new()
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Add(T entity);
    }
}
