namespace AmLite.Repository.Models
{
    using System.Diagnostics.CodeAnalysis;
    /// <summary>
    /// Represents a Division in aM 
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Division
    {
        /// <summary>
        /// Primary key of a Division
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the division
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Collection Navigation to Teams entity
        /// </summary>
        public List<Team> Teams { get; set; }

        /// <summary>
        /// Collection Navigation to Locations entity
        /// </summary>
        public List<Location> Locations { get; set; }
    }
}