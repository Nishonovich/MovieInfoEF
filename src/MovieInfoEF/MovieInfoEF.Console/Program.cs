using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.Interfaces;
using MovieInfoEF.Service.Services;
using System;
using System.Dynamic;

public class Program
{
    static async Task Main(string[] args)
    {
        //AppDbContext appDbContext = new AppDbContext();
        //IGenericRepository<User> genericRepository = new GenericRepository<User>(appDbContext);
        //User user = new User
        //{
        //    FirstName = "Panji",
        //    LastName = "Supermen",
        //    PhoneNumber = "+998931234567",
        //    BirthDate = DateOnly.Parse("2005/01/01"),
        //    Email = "pangi@gmail.com",
        //    Gender = true,
        //    Login = "Panjioff",
        //    Password = "panji12",
        //};

        //await genericRepository.CreateAsync(user);
        //await appDbContext.SaveChangesAsync();

        ////CreateAsync !!!
        IActorService actorService = new ActorService();

        //var actor = await actorService.CreateAsync(new ActorCreateDto()
        //{
        //    FirstName = "Mamat",
        //    LastName = "Mamatjonov",
        //    BirthDate = DateOnly.Parse("1987-12-31"),
        //    IsMale = true,
        //    Hobby = "Ot minish, suzish",
        //});

        //Console.WriteLine(actor.Hobby);

        //// DeleteAsync !!!
        //IActorService actorService = new ActorService();

        //var actorDel = await actorService.DeleteAsync(p => p.Id == 1);

        //Console.WriteLine(actorDel);

        //IActorService actorService = new ActorService();

        //var allActor = await actorService.GetAllAsync();

        //foreach (var item in allActor)
        //{
        //    Console.WriteLine(item.FirstName);
        //}

        ////Getasync tekshirildi
        ///
        //var actor = await actorService.GetAsync(p => p.Id == 10);

        //Console.WriteLine(actor is null);

        //Update tekshirildi.
        //var actUp = await actorService.UpdateAsync(2, new ActorCreateDto()
        //{
        //    FirstName = "Nurmamat"
        //});

        //Console.WriteLine(actUp.FirstName);

        //IDirectorService directorService = new DirectorService();

        //var director = await directorService.CreateAsync(new DirectorCreateDto
        //{
        //    FirstName = "Dadajon",
        //    LastName = "Botiraliev",
        //    BirthDate = DateOnly.Parse("1998-01-08"),
        //    IsMale = true,
        //    Hobby = "Collicsiya yig'ish, chess",
        //    Position = "Directorcha"
        //});

        //Console.WriteLine(director.FirstName);

        //var direcDell = await directorService.DeleteAsync(p => p.Id == 2);
        //Console.WriteLine(direcDell);

        //var allActor = await directorService.GetAllAsync();

        //foreach (var item in allActor)
        //{
        //    Console.WriteLine(item.LastName + " " + item.FirstName);
        //}

        //var director = await directorService.GetAsync(p => p.Id == 1);

        //Console.WriteLine(director.Hobby);


        //Update tekshirildi.
        //var actUp = await directorService.UpdateAsync(7, new DirectorCreateDto()
        //{
        //    FirstName = "Nurbek"
        //});

        //Console.WriteLine(actUp.FirstName + " " + actUp.LastName);

        IGenreService genreService = new GenreService();
        var genreService = await genreService.CreateAsync("Romantic");












    }
}