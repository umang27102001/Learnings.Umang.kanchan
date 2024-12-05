

namespace EntityFramework.Models
{
    /// <summary>
    /// Represents a team in aM
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Primary key of a team record in database
        /// </summary>
        public int TeamId { get; set; }
        /// <summary>
        /// Name of a team
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Collection navigation to Employee entity
        /// </summary>
        public List<Employee> EmployeeList { get; set; }
        /// <summary>
        /// Collection navigation to Project entity
        /// </summary>
        public List<Project> ProjectList { get; set; }
        /// <summary>
        /// Foreign key to Division entity
        /// </summary>
        public int DivisionId { get; set; }
        /// <summary>
        /// Reference navigation to Division entity
        /// </summary>
        public Division Division { get; set; }

    }
}
