using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Genreses;
using MovieInfoEF.Data.Repositories.Movies;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.DTO_s.Genres;
using MovieInfoEF.Service.DTO_s.Movie;
using MovieInfoEF.Service.Interfaces;
using MovieInfoEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public MovieService()
        {
            _appDbContext = new AppDbContext();
            _movieRepository = new MovieRepository(_appDbContext);
            _mapper = new Mapper(new MapperConfiguration(p => p.AddProfile<MappingProfile>()));
        }
        public  async Task<MovieViewModel> CreateAsync(MovieCreateDto dto)
        {
            var result = await _movieRepository.GetAsync(p => p.Name.Equals(dto.Name) 
                      && p.Country.Equals(dto.Country) && p.MovieYear.Equals(dto.MovieYear));

            if (result is not null)
                throw new Exception("Bu Movie bor");

            var newMovie = await _movieRepository.CreateAsync(_mapper.Map<Movie>(dto));
            newMovie.CreatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<MovieViewModel>(newMovie);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Movie, bool>> expression)
        {
            var movies = _movieRepository.GetAll(expression);
            if (!movies.Any())
                throw new Exception("Movie Not found");

            _movieRepository.DeleteRange(movies);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<IEnumerable<MovieViewModel>> GetAllAsync(Expression<Func<Movie, bool>>? expression = null)
        {
            var result = _movieRepository.GetAll(expression);
            return Task.FromResult(_mapper.Map<IEnumerable<MovieViewModel>>(result));
        }

        public async Task<MovieViewModel?> GetAsync(Expression<Func<Movie, bool>> expression)
        {
            var movie = await _movieRepository.GetAsync(expression);
            return _mapper.Map<MovieViewModel?>(movie);
        }

        public async Task<MovieViewModel> UpdateAsync(Int64 id, MovieCreateDto dto)
        {
            var movie = await _movieRepository.GetAsync(p => p.Id == id);

            if (movie is null)
                throw new Exception("Bunday Movie yo'q");

            if (dto.Name.Equals(String.Empty))
                dto.Name = movie.Name;

            if (dto.Country.Equals(String.Empty))
                dto.Country = movie.Country;

            if (dto.Duration.Equals(String.Empty))
                dto.Duration = movie.Duration;

            if (dto.Language.Equals(String.Empty))
                dto.Language = movie.Language;

            if (dto.ImagePath.Equals(String.Empty))
                dto.ImagePath = movie.ImagePath;

            dto.MovieYear = movie.MovieYear;
            dto.PremiereDate = movie.PremiereDate;

            var MovieUp = _mapper.Map(dto, movie);
            MovieUp.UpdatedDate = DateOnly.FromDateTime(DateTime.UtcNow);

            await _movieRepository.UpdateAsync(MovieUp);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<MovieViewModel>(MovieUp);
        }
    }
}
