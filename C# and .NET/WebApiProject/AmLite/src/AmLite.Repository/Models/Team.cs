namespace AmLite.Repository.Models
{
    using System.Diagnostics.CodeAnalysis;
    /// <summary>
    /// Represents a team in aM
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Team
    {
        /// <summary>
        /// Id of a team
        /// </summary>
        public int Id { get; set; }
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

        /// <summary>
        /// Foreign key to Location entity
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// Reference navigation to Location entity
        /// </summary>
        public Location Location { get; set; }
    }
}