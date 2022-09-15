using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories
{
    // krat amallar generic qilib ketilgan 
    public interface IGenericRepository<T>
    {
        Task<T> CreateAsync(T entity); // Icreatable

        void DeleteRange(IEnumerable<T> entities); // IDeleteable

        Task<T?> GetAsync(Expression<Func<T, bool>> expression); // IReadable Get
        IQueryable<T> GetAll(Expression<Func<T, bool>>? expression = null);// IReadable GetAll

        Task<T> UpdateAsync(T entity); // IUpdateable
    }
}
