using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        //Constuctor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            
        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, CategoryName="Thriller"},
                new Category { CategoryId=2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Crime" },
                new Category { CategoryId = 4, CategoryName = "Romance" },
                new Category { CategoryId = 5, CategoryName = "Comedy" }
            );


            mb.Entity<Movie>().HasData(
                
                //seeded 3 movies
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Shutter Island",
                    Year = 2010,
                    Director = "Martin Scorsese",
                    Rating = "R",
                },
                new Movie
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "About Time",
                    Year = 2013,
                    Director = "Richard Curtis",
                    Rating = "R",
                },
                new Movie
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "The Departed",
                    Year = 2006,
                    Director = "Martin Scorsese",
                    Rating = "R",
                }
            );
        }
    }
}
