using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Genreses;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.DTO_s.Genres;
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
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public GenreService()
        {
            _appDbContext = new AppDbContext();
            _genreRepository = new GenreseRepository(_appDbContext);
            _mapper = new Mapper(new MapperConfiguration(p => p.AddProfile<MappingProfile>()));
        }
        public async Task<GenreViewModel> CreateAsync(GenreCreateDto dto)
        {
            var res = await _genreRepository.GetAsync(p => p.Name.Equals(dto.Name));


            if (res is not null)
            {
                throw new Exception("Bu Genre bor");
            }
            var newGenre = await _genreRepository.CreateAsync(_mapper.Map<Genre>(dto));
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<GenreViewModel>(newGenre);
           
        }

        public Task<bool> DeleteAsync(Expression<Func<Genre, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GenreViewModel>> GetAllAsync(Expression<Func<Genre, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<GenreViewModel?> GetAsync(Expression<Func<Genre, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<GenreViewModel> UpdateAsync(long id, GenreCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
