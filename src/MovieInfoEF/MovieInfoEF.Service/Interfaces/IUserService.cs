using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Movie;
using MovieInfoEF.Service.DTO_s.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> CreateAsync(UserCreateDto dto);

        Task<UserViewModel> UpdateAsync(Int64 id, UserCreateDto dto);

        Task<bool> DeleteAsync(Expression<Func<User, bool>> expression);

        Task<UserViewModel?> GetAsync(Expression<Func<User, bool>> expression);

        Task<IEnumerable<UserViewModel>> GetAllAsync(Expression<Func<User, bool>>? expression = null);
    }
}
