using AutoMapper;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.Director;
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


        }
    }
}
