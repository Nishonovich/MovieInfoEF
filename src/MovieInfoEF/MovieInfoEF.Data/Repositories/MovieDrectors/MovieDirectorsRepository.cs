using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.MovieDrectors
{
    public class MovieDirectorsRepository : GenericRepository<MovieDirector>, IMovieDrectorsRepository
    {
        public MovieDirectorsRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
