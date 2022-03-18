using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfEntityRepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {

            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {

            return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);

        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null ? await _context.Set<TEntity>().ToListAsync() : await _context.Set<TEntity>().Where(filter).ToListAsync();

        }

        public async Task<bool> Update(TEntity entity)
        {

            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
