using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.DTO_s.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Interfaces
{
    public interface IGenreService
    {
        Task<GenreViewModel> CreateAsync(GenreCreateDto dto);

        Task<GenreViewModel> UpdateAsync(Int64 id, GenreCreateDto dto);

        Task<bool> DeleteAsync(Expression<Func<Genre, bool>> expression);

        Task<GenreViewModel?> GetAsync(Expression<Func<Genre, bool>> expression);

        Task<IEnumerable<GenreViewModel>> GetAllAsync(Expression<Func<Genre, bool>>? expression = null);
    }
}
