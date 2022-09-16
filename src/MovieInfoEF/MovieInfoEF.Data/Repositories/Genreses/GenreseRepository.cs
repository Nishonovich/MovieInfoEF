using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.Genreses
{
    public class GenreseRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreseRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
