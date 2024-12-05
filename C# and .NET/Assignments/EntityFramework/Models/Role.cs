namespace EntityFramework.Models
{
    /// <summary>
    /// Represents a Role of an employee in aM
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Primary key of a Role record in the database
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Name of a role
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// Reference navigation to Employeees entity
        /// </summary>
        public List<Employee> Employees { get; set; }
    }
}
