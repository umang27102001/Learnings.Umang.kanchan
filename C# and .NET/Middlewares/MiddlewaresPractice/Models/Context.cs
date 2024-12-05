using Microsoft.EntityFrameworkCore;

namespace MiddlewaresPractice.Models
{
    public class Context: DbContext
    {
        public DbSet<FilePath> FilePath { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=NewDellDb;Integrated Security=True");
        }
    }
}
