namespace AmLite.Business
{
    using AmLite.Abstractions.Constants;
    using AmLite.Abstractions.Result.TransactionResult;
    using AmLite.Abstractions.Result.TransactionResult.Interfaces;
    using AmLite.Repository;
    using AmLite.Repository.Models;

    /// <inheritdoc cref="IAmBusiness"/>
    public class AmBusiness : IAmBusiness
    {
        #region Fields and properties

        private readonly IAmRepository _amRepository;

        #endregion

        #region Constructor.

        /// <summary>
        /// Initializes an instance of <see cref="AmBusiness"/>
        /// </summary>
        /// <param name="amRepository">
        /// this is used to provide the instance of IAmRepository when required using Dependency injection
        /// </param>
        public AmBusiness(IAmRepository amRepository)
        {
            this._amRepository = amRepository;
        }

        #endregion

        #region Public methods.

        /// <inheritdoc />
        public async Task<IResult> AddEmployee(Employee emp, CancellationToken token)
        {
            var result = await this.GetEmployeeByEmailId(emp.Email, token);
            if (!result.IsError)
            {
                return new Result
                {
                    IsError = true,
                    ErrorMessage = AppConstants.EmployeeAlreadyExists
                };
            }

            var res = await this._amRepository.AddEmployee(emp, token);
            if (res.IsError)
            {
                return new Result
                {
                    IsError = true,
                    ErrorMessage = res.ErrorMessage
                };
            }

            return new Result
            {
                IsError = false,
                ErrorMessage = res.ErrorMessage
            };

        }

        /// <inheritdoc />
        public async Task<IOneResult<Employee>> GetEmployeeByEmailId(string email, CancellationToken token)
        {
            var repoResult = await this._amRepository.GetEmployeeByEmailId(email, token);
            if (repoResult.IsError)
            {
                return new OneResult<Employee>
                {
                    IsError = true,
                    Resource = null,
                    ErrorMessage = repoResult.ErrorMessage
                };
            }

            return new OneResult<Employee>
            {
                IsError = false,
                Resource = repoResult.Resource,
                ErrorMessage = repoResult.ErrorMessage,
            };

        }
        /// <inheritdoc />
        public async Task<IOneResult<List<Employee>>> GetAllEmployees(CancellationToken token)
        {
            var repoResult = await this._amRepository.GetAllEmployees(token);
            if (repoResult.IsError)
            {
                return new OneResult<List<Employee>>
                {
                    IsError = true,
                    Resource = new List<Employee> { },
                    ErrorMessage = AppConstants.NoEmployeeFound
                };
            }

            return new OneResult<List<Employee>>
            {
                IsError = false,
                Resource = repoResult.Resource,
                ErrorMessage = repoResult.ErrorMessage
            };
        }

        /// <inheritdoc />
        public async Task<IResult> UpdateEmployee(Employee emp, string email, CancellationToken token)
        {

            var result = await this.GetEmployeeByEmailId(email, token);

            if (result.IsError)
            {
                return result;
            }

            var res = await this._amRepository.UpdateEmployee(emp, email, token);

            if (res.IsError)
            {
                return new Result
                {
                    IsError = true,
                    ErrorMessage = res.ErrorMessage
                };
            }

            return new Result
            {
                IsError = false,
                ErrorMessage = res.ErrorMessage
            };

        }

        /// <inheritdoc />
        public async Task<IResult> RemoveEmployee(string email, CancellationToken token)
        {
            var result = await this.GetEmployeeByEmailId(email, token);

            if (result.IsError)
            {
                return result;
            }

            var res = await this._amRepository.RemoveEmployee(email, token);

            if (res.IsError)
            {
                return new Result
                {
                    IsError = true,
                    ErrorMessage = res.ErrorMessage
                };
            }

            return new Result
            {
                IsError = false,
                ErrorMessage = res.ErrorMessage
            };
        }

        /// <inheritdoc />
        public async Task<IResult> IncreaseSalary(double amount, CancellationToken token)
        {
            var result = await this.GetAllEmployees(token);
            if (result.IsError)
            {
                return result;
            }

            var res = this._amRepository.IncreaseSalary(amount, token);

            if (res.IsError)
            {
                return new Result
                {
                    IsError = true,
                    ErrorMessage = res.ErrorMessage
                };
            }
            return new Result
            {
                IsError = false,
                ErrorMessage = res.ErrorMessage
            };

        }
        #endregion
    }
}