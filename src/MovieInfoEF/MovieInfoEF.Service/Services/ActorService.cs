using AutoMapper;
using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories.Actors;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.Interfaces;
using MovieInfoEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        // constructor 
        public ActorService()
        {
            _appDbContext = new AppDbContext();
            _actorRepository = new ActorRepository(_appDbContext);
            _mapper = new Mapper( new MapperConfiguration(p => p.AddProfile<MappingProfile>()));
        }
        public async Task<ActorViewModel> CreateAsync(ActorCreateDto dto)
        {
            var result = await _actorRepository.GetAsync(p => p.FirstName.Equals(dto.FirstName)
                         && p.LastName.Equals(dto.LastName) && p.BirthDate.Equals(dto.BirthDate));

            if(result is not null) 
            {
                throw new Exception("Bu Actor bor");
            }

            var newActor = await _actorRepository.CreateAsync(_mapper.Map<Actor>(dto));
            newActor.CreatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<ActorViewModel>(newActor);

        }

        public async Task<bool> DeleteAsync(Expression<Func<Actor, bool>> expression)
        {
            var allActors = _actorRepository.GetAll(expression);
            if (!allActors.Any())
            {
                throw new Exception("Actor Not found");
            }
            
            _actorRepository.DeleteRange(allActors);
            await _appDbContext.SaveChangesAsync();
            return true;

        }

        public Task<IEnumerable<ActorViewModel>> GetAllAsync(Expression<Func<Actor, bool>>? expression= null)
        {

            var result = _actorRepository.GetAll(expression);

            // 
            return Task.FromResult(_mapper.Map<IEnumerable<ActorViewModel>>(result));
        }

        public async Task<ActorViewModel?> GetAsync(Expression<Func<Actor, bool>> expression)
        {
            var result = await _actorRepository.GetAsync(expression);
            
            return _mapper.Map<ActorViewModel?>(result);
            
        }

        public async Task<ActorViewModel> UpdateAsync(Int64 id, ActorCreateDto dto)
        {
            var actor = await _actorRepository.GetAsync(actor => actor.Id == id);
            if (actor is null)
            {
                throw new Exception("Bunday actor yo'q");
            }

            if (dto.FirstName.Equals(string.Empty))
                dto.FirstName = actor.FirstName;

            if (dto.LastName.Equals(string.Empty))
                dto.LastName = actor.LastName;

            if (dto.Hobby.Equals(string.Empty))
                dto.Hobby = actor.Hobby;

            if (dto.IsMale == null)
                dto.IsMale = actor.IsMale;

            dto.BirthDate = actor.BirthDate;

            var actorUp = _mapper.Map(dto, actor);
            actorUp.UpdatedDate = DateOnly.FromDateTime(DateTime.UtcNow);
            await _actorRepository.UpdateAsync(actorUp);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<ActorViewModel>(actorUp);
        }
    }
}
