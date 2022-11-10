using Microsoft.EntityFrameworkCore;

namespace TheMovieWatchlist.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) :base(options)
        {
            
        }
    }
}
