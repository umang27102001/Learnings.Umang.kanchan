namespace AmLite.Repository
{
    using AmLite.Abstractions.Constants;
    using AmLite.Abstractions.Result.RepositoryResult;
    using AmLite.Abstractions.Result.RepositoryResult.Interfaces;
    using AmLite.Repository.DbContexts;
    using AmLite.Repository.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc cref="IAmRepository"/>
    [ExcludeFromCodeCoverage]
    public class AmRepository : IAmRepository
    {
        #region Fields an Properties.
        private readonly AmDbContext _dbContext;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of <see cref="AmRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public AmRepository(AmDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        #endregion

        #region public methods.

        /// <inheritdoc />
        public async Task<IRepositoryOneResult<Employee>> GetEmployeeByEmailId(string email, CancellationToken token)
        {
            var emp = await this._dbContext.Employees.FirstOrDefaultAsync(e => (e.Email == email && !e.IsDeleted));
            if (emp == null)
            {
                return new RepositoryOneResult<Employee>
                {
                    IsError = true,
                    ErrorMessage = AppConstants.EmployeeDoesNotExist
                };
            }

            return new RepositoryOneResult<Employee>
            {
                IsError = false,
                Resource = emp
            };
        }

        /// <inheritdoc />
        public async Task<IRepositoryResult> AddEmployee(Employee emp, CancellationToken token)
        {
            try
            {
                this._dbContext.Employees.Add(emp);
                await this._dbContext.SaveChangesAsync();
                return new RepositoryResult
                {
                    IsError = false,
                    ErrorMessage = AppConstants.AddEmployeeSuccess,
                };
            }
            catch (Exception ex)
            {
                return new RepositoryResult
                {
                    IsError = true,
                    ErrorMessage = AppConstants.AddEmployeeFailure,
                };
            }
        }

        /// <inheritdoc />
        public async Task<IRepositoryOneResult<List<Employee>>> GetAllEmployees(CancellationToken token)
        {
            try
            {
                var employees = await this._dbContext.Employees.Where(e => !e.IsDeleted).ToListAsync();
                if (employees.Count() == 0)
                {
                    return new RepositoryOneResult<List<Employee>>
                    {
                        IsError = true,
                        ErrorMessage = AppConstants.NoEmployeeFound
                    };
                }
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = false,
                    Resource = employees,
                };
            }
            catch (Exception ex)
            {
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = true,
                    ErrorMessage = ex.Message,
                };
            }
        }

        /// <inheritdoc />
        public async Task<IRepositoryResult> UpdateEmployee(Employee emp, string email, CancellationToken token)
        {
            try
            {
                var employee = await this._dbContext.Employees.FirstAsync(e => e.Email == email);
                employee.Phone = emp.Phone;
                employee.Address = emp.Address;
                employee.TeamId = emp.TeamId;
                employee.Name = emp.Name;
                employee.Email = emp.Email;
                employee.RoleId = emp.RoleId;
                employee.Salary = emp.Salary;
                await this._dbContext.SaveChangesAsync();
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = false,
                    ErrorMessage = AppConstants.UpdateEmployeeDetailsSuccess
                };
            }
            catch (Exception ex)
            {
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = true,
                    ErrorMessage = AppConstants.UpdateEmployeeDetailsFailure,
                };
            }
        }

        /// <inheritdoc />
        public async Task<IRepositoryResult> RemoveEmployee(string email, CancellationToken token)
        {
            try
            {
                var result = await this.GetEmployeeByEmailId(email, token);
                var emp = result.Resource;
                emp.IsDeleted = true;
                await this._dbContext.SaveChangesAsync();
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = false,
                    ErrorMessage = AppConstants.RemoveEmployeeSuccess,
                };
            }
            catch (Exception ex)
            {
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = true,
                    ErrorMessage = AppConstants.RemoveEmployeeFailure,
                };
            }
        }

        /// <inheritdoc />
        public IRepositoryResult IncreaseSalary(double amount, CancellationToken token)
        {
            try
            {
                this._dbContext.Employees.ExecuteUpdate(setters => setters.SetProperty(e => e.Salary, e => e.Salary + amount));
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = false,
                    ErrorMessage = AppConstants.SalaryIncreasedSuccessfully,
                };
            }
            catch (Exception ex)
            {
                return new RepositoryOneResult<List<Employee>>
                {
                    IsError = true,
                    ErrorMessage = AppConstants.SalaryIncreaseFailure,
                };
            }
        }
        #endregion
    }
}