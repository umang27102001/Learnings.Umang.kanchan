
namespace EntityFramework.Models
{
    /// <summary>
    /// Represents a project in aM
    /// </summary>
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
        public List<Team> Teams { get; set; }
    }
}
