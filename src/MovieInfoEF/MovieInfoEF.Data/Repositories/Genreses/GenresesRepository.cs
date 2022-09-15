using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.Genreses
{
    public class GenresesRepository : GenericRepository<Genres>, IGenresRepository
    {
        public GenresesRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
