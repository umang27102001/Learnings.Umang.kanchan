namespace AmLite.Abstractions.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// AmLiteEmployee Data Transfer Object
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class EmployeeDto
    {
        /// <summary>
        /// Name of the employee
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Email Id of the employee
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Phone number of employee
        /// </summary>
        [Phone]
        public string Phone { get; set; }

        /// <summary>
        /// Address of employee
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// AmLiteTeam Id of the employee: Foreign key to AmLiteTeam
        /// </summary>
        [Required]
        public int TeamId { get; set; }

        /// <summary>
        /// AmLiteRole ID of the employee: Foreign key to AmLiteRole
        /// </summary>
        [Required]
        public int RoleId { get; set; }

        /// <summary>
        /// Salary of employee
        /// </summary>
        public double Salary { get; set; }
    }
}