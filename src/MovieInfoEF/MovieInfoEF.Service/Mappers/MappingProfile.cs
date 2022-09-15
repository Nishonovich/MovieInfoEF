using AutoMapper;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
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
        }
    }
}
