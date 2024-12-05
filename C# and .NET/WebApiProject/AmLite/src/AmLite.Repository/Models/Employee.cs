namespace AmLite.Repository.Models
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents an employee in aM
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Employee
    {
        /// <summary>
        /// Primary key of an Employee record in Database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Email Id of the employee
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Name of the employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Phone number of employee
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Address of the employee
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Salary of the employee
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Team Id as Foreign key to Team entity to which this employee belengs
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Reference navigation to Team entity
        /// </summary>
        public Team Team { get; set; }

        /// <summary>
        /// Team Id as Foreign key to Role entity to which this employee belengs
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Reference navigation to Role entity
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Flag for soft deletion.
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}