using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Actors;
using MovieInfoEF.Data.Repositories.Users;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.User;
using MovieInfoEF.Service.Interfaces;
using MovieInfoEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        // constructor 
        public UserService()
        {
            _appDbContext = new AppDbContext();
            _userRepository = new UserRepository(_appDbContext);
            _mapper = new Mapper(new MapperConfiguration(p => p.AddProfile<MappingProfile>()));
        }

        public async Task<UserViewModel> CreateAsync(UserCreateDto dto)
        {
            var user = await _userRepository.GetAsync(p => p.FirstName.Equals(dto.FirstName)
                         && p.LastName.Equals(dto.LastName) && p.BirthDate.Equals(dto.BirthDate));

            if (user is not null)
                throw new Exception("User Mavjud ");

            var newUser = await _userRepository.CreateAsync(_mapper.Map<User>(dto));
            newUser.CreatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            _appDbContext.SaveChanges();
            return _mapper.Map<UserViewModel>(newUser);
        }

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            var allUser = _userRepository.GetAll(expression);
            if (!allUser.Any())
            {
                throw new Exception("User Not found");
            }

            _userRepository.DeleteRange(allUser);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<UserViewModel>> GetAllAsync(Expression<Func<User, bool>>? expression = null)
        {
            var result = _userRepository.GetAll(expression);
            // 
            return Task.FromResult(_mapper.Map<IEnumerable<UserViewModel>>(result));
        }

        public async Task<UserViewModel?> GetAsync(Expression<Func<User, bool>> expression)
        {
            var result = await _userRepository.GetAsync(expression);

            return _mapper.Map<UserViewModel?>(result);
        }

        public async Task<UserViewModel> UpdateAsync(long id, UserCreateDto dto)
        {
            var user = await _userRepository.GetAsync(u => u.Id == id);
            if (user is null)
            {
                throw new Exception("Bunday User yo'q");
            }

            if (dto.FirstName.Equals(String.Empty))
                dto.FirstName = user.FirstName;

            if (dto.LastName.Equals(String.Empty))
                dto.LastName = user.LastName;

            dto.BirthDate = user.BirthDate;

            if (dto.Email.Equals(String.Empty))
                dto.Email = user.Email;

            if (dto.Gender == null)
                dto.Gender = user.Gender;
            
            if (dto.PhoneNumber.Equals(String.Empty))
                dto.PhoneNumber = user.PhoneNumber;

            if (dto.Login.Equals(String.Empty))
                dto.Login = user.Login;

            if (dto.Password.Equals(String.Empty))
                dto.Password = user.Password;

            if (dto.UserPosit.Equals(String.Empty))
                dto.UserPosit = user.UserPosit;

            var userUp = _mapper.Map(dto, user);
            userUp.UpdatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            await _userRepository.UpdateAsync(userUp);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<UserViewModel>(userUp);


        }
    }
}
