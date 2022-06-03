using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenreMovie>()
                .HasKey(gm => new { gm.genreId, gm.movieId });
        }

        public DbSet<Movie>? Movie { get; set; }
        public DbSet<Genre>? Genre { get; set; }
        public DbSet<GenreMovie>? genreMovies { get; set; }

    }
}
