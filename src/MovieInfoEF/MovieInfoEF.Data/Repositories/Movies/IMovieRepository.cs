using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.Repositories.Movies
{
    internal interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
