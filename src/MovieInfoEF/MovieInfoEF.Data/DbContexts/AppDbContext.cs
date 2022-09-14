using Microsoft.EntityFrameworkCore;
using MovieInfoEF.Domain.Constants;
using MovieInfoEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Data.DbContexts
{
    public class AppDbContext:DbContext
    {
        // db table lar nomlari 
        public virtual DbSet<Actor> Actors { get; set; } = null!; // db table null emas degani 
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<Genres> Genres { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MovieDirector> MoversDirectors { get; set; } = null!;
        public virtual DbSet<MovieGenres> MovieGenres { get; set; } = null!;
        public virtual DbSet<MovieHero> MovieHeroes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        // db connect bo'lyabdi 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseNpgsql(DatabaseConstants.CONNECTION_STRING);
        }
        // db ga proplarni unique (yagona, takrorlanmas) qilish canstiring qo'shamiz
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>()
                .HasIndex(p => p.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(p => p.Login)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(p => p.PhoneNumber)
                .IsUnique();


            
        }

    }
}
