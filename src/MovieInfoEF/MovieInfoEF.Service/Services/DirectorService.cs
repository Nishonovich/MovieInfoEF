using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Actors;
using MovieInfoEF.Data.Repositories.Directors;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.Interfaces;
using MovieInfoEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public DirectorService()
        {
            _appDbContext = new AppDbContext();
            _directorRepository = new DirectorRepository(_appDbContext);
            _mapper = new Mapper(new MapperConfiguration(p => p.AddProfile<MappingProfile>()));
        }


        public async Task<DirectorViewModel> CreateAsync(DirectorCreateDto dto)
        {
            var res = await _directorRepository.GetAsync(p => p.FirstName.Equals(dto.FirstName)
            && p.LastName.Equals(dto.LastName) && p.BirthDate.Equals(dto.BirthDate));


            if (res is not null)
            {
                throw new Exception("Bu Director bor");
            }

            var newDirector = await _directorRepository.CreateAsync(_mapper.Map<Director>(dto));
            newDirector.CreatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<DirectorViewModel>(newDirector);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Director, bool>> expression)
        {
            var allDirector = _directorRepository.GetAll(expression);
            if (!allDirector.Any())
            {
                throw new Exception("Director Not found");
            }

            _directorRepository.DeleteRange(allDirector);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<IEnumerable<DirectorViewModel>> GetAllAsync(Expression<Func<Director, bool>>? expression = null)
        {
            var result = _directorRepository.GetAll(expression);

            // 
            return Task.FromResult(_mapper.Map<IEnumerable<DirectorViewModel>>(result));
        }

        public async Task<DirectorViewModel?> GetAsync(Expression<Func<Director, bool>> expression)
        {
            var director = await _directorRepository.GetAsync(expression);

            return _mapper.Map<DirectorViewModel?>(director);
        }

        public async Task<DirectorViewModel> UpdateAsync(Int64 id, DirectorCreateDto dto)
        {
         
            var director = await _directorRepository.GetAsync( p => p.Id == id);

            if (director is null)
            {
                throw new Exception("Bunday director yo'q");
            }
            if (dto.FirstName.Equals(string.Empty))
                dto.FirstName = director.FirstName;
            if (dto.LastName.Equals(string.Empty))
                dto.LastName = director.LastName;
            if (dto.Hobby.Equals(string.Empty))
                dto.Hobby = director.Hobby;
            if (dto.IsMale == null)
                dto.IsMale = director.IsMale;
            if (dto.Position.Equals(string.Empty))
                dto.Position = director.Position;
           
            dto.BirthDate = director.BirthDate;

            var directorUp = _mapper.Map(dto, director);
            directorUp.UpdatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            await _directorRepository.UpdateAsync(directorUp);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<DirectorViewModel>(directorUp);
        }
    }
}
