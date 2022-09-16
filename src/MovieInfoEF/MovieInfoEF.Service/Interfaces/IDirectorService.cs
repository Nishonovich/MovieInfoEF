using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Interfaces
{
    public interface IDirectorService
    {
        Task<DirectorViewModel> CreateAsync(DirectorCreateDto dto);

        Task<DirectorViewModel> UpdateAsync(Int64 id, DirectorCreateDto dto);

        Task<bool> DeleteAsync(Expression<Func<Director, bool>> expression);

        Task<DirectorViewModel?> GetAsync(Expression<Func<Director, bool>> expression);

        Task<IEnumerable<DirectorViewModel>> GetAllAsync(Expression<Func<Director, bool>>? expression = null);

    }
}
