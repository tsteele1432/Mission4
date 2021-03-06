// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        //Shows the inital movies that are seeded
                        new
                        {
                            MovieId = 1,
                            Category = "Mystery/Thriller",
                            Director = "Martin Scorsese",
                            Edited = false,
                            Rating = "R",
                            Title = "Shutter Island",
                            Year = 2010
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy/Drama",
                            Director = "Richard Curtis",
                            Edited = false,
                            Rating = "R",
                            Title = "About Time",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Crime/Thriller",
                            Director = "Martin Scorsese",
                            Edited = false,
                            Rating = "R",
                            Title = "The Departed",
                            Year = 2006
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
