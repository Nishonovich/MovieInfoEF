using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Genreses;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
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

        public async Task<bool> DeleteAsync(Expression<Func<Genre, bool>> expression)
        {
            var allGenre = _genreRepository.GetAll(expression);
         
            if (!allGenre.Any())
            {
                throw new Exception("Genre not found");
            }

            _genreRepository.DeleteRange(allGenre);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<GenreViewModel>> GetAllAsync(Expression<Func<Genre, bool>>? expression = null)
        {
            var result = _genreRepository.GetAll(expression);
            return Task.FromResult(_mapper.Map<IEnumerable<GenreViewModel>>(result));
        }

        public async Task<GenreViewModel?> GetAsync(Expression<Func<Genre, bool>> expression)
        {
            
            var result = await _genreRepository.GetAsync(expression);

            return _mapper.Map<GenreViewModel?>(result);
        }

        public async Task<GenreViewModel> UpdateAsync(Int64 id, GenreCreateDto dto)
        {
            var genre = await _genreRepository.GetAsync(p => p.Id == id);
            if (genre is null)
            {
                throw new Exception("Bunday actor yo'q");
            }

            var genreUp = _mapper.Map(dto, genre);
       
            await _genreRepository.UpdateAsync(genreUp);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<GenreViewModel>(genreUp);
        }
    }
}
