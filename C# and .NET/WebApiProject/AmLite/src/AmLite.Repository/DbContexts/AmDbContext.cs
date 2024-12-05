namespace AmLite.Repository.DbContexts
{
    using AmLite.Repository.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Diagnostics.CodeAnalysis;
    /// <summary>
    /// Represents context subclass to configure dbcontext and model for db operations
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class AmDbContext : DbContext
    {
        /// <summary>
        /// DbSet to include Division class as entity in the model
        /// </summary>
        public DbSet<Division> Divisions { get; set; }

        /// <summary>
        /// DbSet to include project class as an entity in the model
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// DbSet to include Employee class as an entity in the model
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// DbSet to include Location class as an entity in the model
        /// </summary>
        public DbSet<Location> Locations { get; set; }

        /// <summary>
        /// DbSet to include Teams class as an entity in the model
        /// </summary>
        public DbSet<Team> Teams { get; set; }

        /// <summary>
        /// DbSet to include Roles class as an entity in the model
        /// </summary>
        public DbSet<Role> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AmmDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}