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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Category = "Mystery/Thriller",
                    Title = "Shutter Island",
                    Year = 2010,
                    Director = "Martin Scorsese",
                    Rating = "R",
                },
                new Movie
                {
                    MovieId = 2,
                    Category = "Comedy/Drama",
                    Title = "About Time",
                    Year = 2013,
                    Director = "Richard Curtis",
                    Rating = "R",
                },
                new Movie
                {
                    MovieId = 3,
                    Category = "Crime/Thriller",
                    Title = "The Departed",
                    Year = 2006,
                    Director = "Martin Scorsese",
                    Rating = "R",
                }
            );
        }
    }
}
