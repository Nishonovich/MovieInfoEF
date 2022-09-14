using Microsoft.EntityFrameworkCore;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // DbSet generic qilindi
        protected readonly AppDbContext _dbContext;
        protected DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appContext) 
        {
            _dbContext = appContext;
            _dbSet = _dbContext.Set<T>();
        }


        public async Task<T> CreateAsync(T entity)
        {
            var res = await _dbSet.AddAsync(entity);

            return res.Entity;
        }

        public void DeleteRange(IEnumerable<T> entities)
            => _dbSet.RemoveRange(entities);


        public IQueryable<T> GetAll(Expression<Func<T, bool>>? expression = null)
            => expression is null ? _dbSet : _dbSet.Where(expression);


        public Task<T?> GetAsync(Expression<Func<T, bool>> expression)
            => _dbSet.FirstOrDefaultAsync(expression);

        public Task<T> UpdateAsync(T entity)
            => Task.FromResult(_dbSet.Update(entity).Entity);

    }
}
