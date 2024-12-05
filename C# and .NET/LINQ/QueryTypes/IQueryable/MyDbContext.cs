
namespace IQueryable
{
    using Microsoft.EntityFrameworkCore;
    public class MyDbContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Platform { get; set; }
        public DbSet<Platform> Rating { get; set; }
        public DbSet<Rating> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MovieDb;Integrated Security=True");
        }
    }
}
