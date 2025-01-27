using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moviemanagement.Domein.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviemanagement.DataAcces.Context
{
    public class MovieManagementDbContext:DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Biography> Biographies { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Tom", LastName = "Hanks" },
                new Actor { Id = 2, FirstName = "Keanu", LastName = "Reeves" },
                new Actor { Id = 3, FirstName = "Will", LastName = "Smith" }
                );
            modelBuilder.Entity<Movie>().HasData(
                
                new Movie { Id = 1, Name = "Forrest Gump",Description="Box Office we coming", ActorId = 1 },
                new Movie { Id = 2, Name = "The Matrix", Description = "Box Office we coming", ActorId = 2 },
                new Movie { Id = 3, Name = "The Pursuit of Happyness", Description = "Box Office we coming", ActorId = 3 }
                );  
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Drama" },
                new Genre { Id = 2, Name = "Action" },
                new Genre { Id = 3, Name = "Comedy" }
                );
            modelBuilder.Entity<Biography>().HasData(
                new Biography { Id = 1, Description = "Tom Hanks was born in 1956 in California", ActorId = 1 },
                new Biography { Id = 2, Description = "Keanu Reeves was born in 1964 in Lebanon", ActorId = 2 },
                new Biography { Id = 3, Description = "Will Smith was born in 1968 in Pennsylvania", ActorId = 3 }
                );

        }
    }
}
