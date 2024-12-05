namespace AmLite.Business
{
    using AmLite.Abstractions.Result.TransactionResult.Interfaces;
    using AmLite.Repository.Models;

    /// <summary>
    /// Defines the properties and methods to implement business class for AmLite.
    /// </summary>
    public interface IAmBusiness
    {
        /// <summary>
        /// This method is used to add a new Employee in aM family.
        /// </summary>
        /// <param name="emp">
        /// the details of the new employee to be added.
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the result of
        /// the asynchronous operation - true if the processing is successful,
        /// otherwise false is returned.
        /// </returns>
        Task<IResult> AddEmployee(Employee emp, CancellationToken token);

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
        /// A <see cref="Task{TOneResultResult<Employee>}"/> representing the result of
        /// the asynchronous operation - true if the processing is successful,
        /// otherwise false is returned.
        /// </returns>
        Task<IOneResult<Employee>> GetEmployeeByEmailId(string email, CancellationToken token);

        /// <summary>
        /// This method is used to change the details of an employee
        /// </summary>
        /// <param name="emp">
        /// New details of an existing employee
        /// </param>
        /// <param name="email">
        /// Email Id of the employee to be changed
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the result of
        /// the asynchronous operation - true if the processing is successful,
        /// otherwise false is returned.
        /// </returns>
        Task<IResult> UpdateEmployee(Employee emp, string email, CancellationToken token);

        /// <summary>
        /// This method is used to delete an existing employee
        /// </summary>
        /// <param name="email">
        /// Email Id of the employee
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the result of
        /// the asynchronous operation - true if the processing is successful,
        /// otherwise false is returned.
        /// </returns>
        Task<IResult> RemoveEmployee(string email, CancellationToken token);

        /// <summary>
        /// This method is used to Increase the salary of all the employees.
        /// </summary>
        /// <param name="amount">
        /// delta salary to be added.
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// A <see cref="Task{TResult}"/> representing the result of
        /// the asynchronous operation - true if the processing is successful,
        /// otherwise false is returned.
        Task<IResult> IncreaseSalary(double amount, CancellationToken token);

        /// <summary>
        /// This method is used to get the list of all the employees in aM family.
        /// </summary>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// A <see cref="Task{IOneResult<List<Employee>>}"/> representing the result of
        /// the asynchronous operation - List of all the employees if the processing is successful,
        /// otherwise empty list is returned.
        Task<IOneResult<List<Employee>>> GetAllEmployees(CancellationToken token);
    }
}