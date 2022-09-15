using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.MovieHeros
{
    public class MovieHeroRepository : GenericRepository<MovieHero>, IMovieHeroRepository
    {
        public MovieHeroRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
