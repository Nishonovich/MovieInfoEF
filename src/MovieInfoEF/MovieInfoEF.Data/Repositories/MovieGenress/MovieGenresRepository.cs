using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.MovieGenress
{
    public class MovieGenresRepository : GenericRepository<MovieGenres>, IMoviGenresRepository
    {
        public MovieGenresRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
