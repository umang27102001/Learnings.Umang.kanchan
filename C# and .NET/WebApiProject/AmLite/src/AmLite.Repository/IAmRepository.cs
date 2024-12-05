namespace AmLite.Repository
{
    using AmLite.Abstractions.Result.RepositoryResult.Interfaces;
    using AmLite.Repository.Models;

    /// <summary>
    /// Defines the properties and methods to implement repository class for AmLite.
    /// </summary>
    public interface IAmRepository
    {
        /// <summary>
        /// This method is used to get an existing employee by its emailId
        /// </summary>
        /// <param name="email">
        /// Email Id of the employee
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// Requested employee if exists.
        /// </returns>

        Task<IRepositoryOneResult<Employee>> GetEmployeeByEmailId(string id, CancellationToken token);
        /// <summary>
        /// This method is used to add a new Employee in aM family.
        /// </summary>
        /// <param name="empDto">
        /// the details of the new employee to be added.
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// ActionResult containing a boolean true for successful addition or false for unsuccessful addition
        /// </returns>

        Task<IRepositoryResult> AddEmployee(Employee emp, CancellationToken token);
        /// <summary>
        /// This method is used to change the details of an employee
        /// </summary>
        /// <param name="empDto">
        /// New details of an existing employee
        /// </param>
        /// <param name="email">
        /// Email Id of the employee to be changed
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// true if success, false if any failure
        /// </returns>
        Task<IRepositoryResult> UpdateEmployee(Employee emp, string email, CancellationToken token);

        /// <summary>
        /// This method is used to delete an existing employee
        /// </summary>
        /// <param name="email">
        /// Email Id of the employee
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param
        /// <returns>
        /// true if successfully deleted else false
        /// </returns>
        Task<IRepositoryResult> RemoveEmployee(string email, CancellationToken token);

        /// <summary>
        /// This method is used to Increase the salary of all the employees.
        /// </summary>
        /// <param name="amount">
        /// delta salary to be added.
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// Repository result containing true if success, false if failure.
        /// </returns>
        IRepositoryResult IncreaseSalary(double amount, CancellationToken token);

        /// <summary>
        /// This method is used to get the list of all the employees in aM family.
        /// </summary>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// List of all employees
        /// </returns>
        Task<IRepositoryOneResult<List<Employee>>> GetAllEmployees(CancellationToken token);
    }
}