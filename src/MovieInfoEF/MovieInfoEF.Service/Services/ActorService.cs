using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Actors;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.Interfaces;
using MovieInfoEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Services
{
    internal class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;
        // constructor 
        public ActorService()
        {
            
            appDbContext = new AppDbContext();
            _actorRepository = new ActorRepository(appDbContext);
            mapper = new Mapper( new MapperConfiguration(p => p.AddProfile<MappingProfile>()));
        }
        public async Task<ActorViewModel> CreateAsync(ActorCreateDto dto)
        {
            var result = await _actorRepository.GetAsync(p => p.FirstName.Equals(dto.FirstName)
            && p.LastName.Equals(dto.LastName) && p.BirthDate.Equals(dto.BirthDate));

            if(result is not null) 
            {
                throw new Exception("Bu Actor bor");
            }

            var newActor = await _actorRepository.CreateAsync(mapper.Map<Actor>(dto));
            await appDbContext.SaveChangesAsync();

            return mapper.Map<ActorViewModel>(newActor);

        }

        public Task<bool> DeleteAsync(Expression<Func<Actor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ActorViewModel>> GetAllAsync(Expression<Func<Actor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ActorViewModel> GetAsync(Expression<Func<Actor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ActorViewModel> UpdateAsync(ActorCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
