namespace AmLite.Repository.Models
{
    using System.Diagnostics.CodeAnalysis;
    /// <summary>
    /// Represents a Role of an employee in aM
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Role
    {
        /// <summary>
        /// Id of the Role
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of a role
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// Reference navigation to Employeees entity
        /// </summary>
        public List<Employee> Employees { get; set; }
        public Role()
        {
            Employees = new List<Employee>();
        }
    }
}