using Microsoft.EntityFrameworkCore;

namespace zajecia5.Models{
     public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<zajecia5.Models.Movie> Movie { get; set; }
    }
}