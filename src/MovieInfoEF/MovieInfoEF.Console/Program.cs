using MovieInfoEF.Data.DbContexts;
using MovieInfoEF.Data.Repositories;
using MovieInfoEF.Domain.Models;
using System;

public class Program
{
    static async Task Main(string[] args)
    {
        AppDbContext appDbContext = new AppDbContext();
        IGenericRepository<User> genericRepository = new GenericRepository<User>(appDbContext);
        User user = new User
        {
            FirstName = "Panji",
            LastName = "Supermen",
            PhoneNumber = "+998931234567",
            BirthDate = DateOnly.Parse("2005/01/01"),
            Email = "pangi@gmail.com",
            Gender = true,
            Login = "Panjioff",
            Password = "panji12",
        };

        await genericRepository.CreateAsync(user);
        await appDbContext.SaveChangesAsync();


    }
}