using AutoMapper;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.DTO_s.Genres;
using MovieInfoEF.Service.DTO_s.Movie;
using MovieInfoEF.Service.DTO_s.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, ActorCreateDto>().ReverseMap();
            CreateMap<Actor, ActorViewModel>().ReverseMap();
            CreateMap<IQueryable<Actor>, List<ActorViewModel>>().ReverseMap();

            CreateMap<Director, DirectorCreateDto>().ReverseMap();
            CreateMap<Director, DirectorViewModel>().ReverseMap();
            CreateMap<IQueryable<Director>, List<DirectorViewModel>>().ReverseMap();

            CreateMap<Genre, GenreCreateDto>().ReverseMap();
            CreateMap<Genre, GenreViewModel>().ReverseMap();
            CreateMap<IQueryable<Genre>, List<GenreViewModel>>().ReverseMap();

            CreateMap<Movie, MovieCreateDto>().ReverseMap();
            CreateMap<Movie, MovieViewModel>().ReverseMap();
            CreateMap<IQueryable<Movie>, List<MovieViewModel>>().ReverseMap();

            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<IQueryable<User>, List<UserViewModel>>().ReverseMap();
        }
    }
}
