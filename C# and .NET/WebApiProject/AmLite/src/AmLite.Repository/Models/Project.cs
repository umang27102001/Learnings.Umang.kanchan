
namespace AmLite.Repository.Models
{
    using System.Diagnostics.CodeAnalysis;
    /// <summary>
    /// Represents a project in aM
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Project
    {
        /// <summary>
        /// Primary key of a project record in database
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// Name of a project
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Collection navigation to Teams entity
        /// </summary>
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}