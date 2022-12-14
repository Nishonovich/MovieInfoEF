using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.Actors
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
