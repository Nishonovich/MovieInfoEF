using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
