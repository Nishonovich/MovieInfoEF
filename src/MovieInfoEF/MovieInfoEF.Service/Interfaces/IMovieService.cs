using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Genres;
using MovieInfoEF.Service.DTO_s.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Interfaces
{
    public interface IMovieService
    {
        Task<MovieViewModel> CreateAsync(MovieCreateDto dto);

        Task<MovieViewModel> UpdateAsync(Int64 id, MovieCreateDto dto);

        Task<bool> DeleteAsync(Expression<Func<Movie, bool>> expression);

        Task<MovieViewModel?> GetAsync(Expression<Func<Movie, bool>> expression);

        Task<IEnumerable<MovieViewModel>> GetAllAsync(Expression<Func<Movie, bool>>? expression = null);
    }
}
