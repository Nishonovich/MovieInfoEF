using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.Directors
{
    public class DirectorRepository : GenericRepository<Director>, IDirectorsRepository
    {
        public DirectorRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
