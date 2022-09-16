using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories;
using MovieInfoEF.Domain.Models;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.DTO_s.Genres;
using MovieInfoEF.Service.DTO_s.Movie;
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

        //var genre = await genreService.CreateAsync(new GenreCreateDto()
        //{
        //    Name = "Melodramma"
        //});
        //Console.WriteLine(genre.Name);


        //var direcDell = await genreService.DeleteAsync(p => p.Id == 2);
        //Console.WriteLine(direcDell);

        //var allActor = await genreService.GetAllAsync(p => p.Id > 1);

        //foreach (var item in allActor)
        //{
        //    Console.WriteLine(item.Name);
        //}

        //var genre = await genreService.GetAsync(p => p.Id == 2);
        //Console.WriteLine(genre.Name);

        //var getUp = await genreService.UpdateAsync(1, new GenreCreateDto()
        //{
        //    Name = "Fantastic"
        //});
        //Console.WriteLine(getUp.Name);

        IMovieService movieService = new MovieService();
        /*var result = await movieService.CreateAsync(new MovieCreateDto()
        {
            Name = "Doctor Strangge",
            Country = MovieInfoEF.Domain.Enums.Country.AQSh,
            Duration = "Bosh rollarda Stiven Strange",
            ImagePath = "path",
            Language = "Angliskiy",
            MovieYear = DateOnly.Parse("2002/12/01"),
            PremiereDate = DateOnly.Parse("2012/12/5")
        });*/

        //Console.WriteLine(result.Name + " " + result.Country);

        /*var check = await movieService.DeleteAsync(x => x.Id == 2);
        Console.WriteLine(check);*/

        /*var movies = await movieService.GetAllAsync();
        foreach (var movie in movies)
        {
            Console.WriteLine(movie.Name + " " + movie.Country);
        }*/

        /*var movie = await movieService.GetAsync(x => x.Id == 4);
        Console.WriteLine(movie.Language);*/

        //var getUp = await movieService.UpdateAsync(3, new MovieCreateDto()
        //{
        //    Duration = "Oltin izlab "
        //});

        //Console.WriteLine(getUp.Name);
















    }
}