using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Interfaces
{
    public interface IActorService
    {
        Task<ActorViewModel> CreateAsync(ActorCreateDto dto);

        Task<ActorViewModel> UpdateAsync(Int64 id, ActorCreateDto dto);

        Task<bool> DeleteAsync(Expression<Func<Actor, bool>> expression);

        Task<ActorViewModel?> GetAsync(Expression<Func<Actor, bool>> expression);

        Task<IEnumerable<ActorViewModel>> GetAllAsync(Expression<Func<Actor, bool>>? expression = null);

    }
}
