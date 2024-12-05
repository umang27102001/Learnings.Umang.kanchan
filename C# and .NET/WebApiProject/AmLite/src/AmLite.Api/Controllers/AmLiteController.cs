namespace AmLite.Api.Controllers
{
    using AmLite.Abstractions.Constants;
    using AmLite.Abstractions.Models;
    using AmLite.Business;
    using AmLite.Repository.Models;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// AmLiteController, used to accept requests related to employees in aM
    /// </summary>

    [Route("")]
    [ApiController]
    public class AmLiteController : ControllerBase
    {
        #region Fields and Properties.
        private readonly IAmBusiness _amBusiness;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor.
        public AmLiteController
            (
                IAmBusiness amBusiness,
                IMapper mapper
            )
        {
            this._amBusiness = amBusiness;
            this._mapper = mapper;
        }
        #endregion

        #region Public methods.

        /// <summary>
        /// This method is used to add a new Employee in aM family.
        /// </summary>
        /// <param name="emp">
        /// The details of the new employee to be added.
        /// </param>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// ActionResult containing a boolean true for successful addition or false for unsuccessful addition
        /// </returns>
        [HttpPost]
        [Route("add-employee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddEmployeeAsync(
                [FromBody] EmployeeDto empDto,
                CancellationToken token)
        {
            // Check if model state is valid
            if (!this.ModelState.IsValid)
            {
                // return bad request.
                return this.BadRequest(this.ModelState);
            }

            try
            {
                var employee = this._mapper.Map<Employee>(empDto);

                var result = await this._amBusiness.AddEmployee(employee, token);

                if (!result.IsError)
                {
                    return this.StatusCode(StatusCodes.Status200OK, result.ErrorMessage);
                }
                return this.StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);
            }
            catch (TaskCanceledException ex)
            {
                return this.StatusCode(StatusCodes.Status504GatewayTimeout, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

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
        [HttpGet]
        [Route("get-by-id/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmployeeByEmailIdAsync(
                [FromRoute][EmailAddress][Required] string email,
                CancellationToken token)
        {
            // Check if model state is valid
            if (!this.ModelState.IsValid)
            {
                // return bad request.
                return this.BadRequest(this.ModelState);
            }

            if (string.IsNullOrEmpty(email))
            {
                return this.BadRequest(AppConstants.InvalidEmailId);
            }

            try
            {
                var result = await this._amBusiness.GetEmployeeByEmailId(email, token);

                if (!result.IsError)
                {
                    return this.StatusCode(StatusCodes.Status200OK, this._mapper.Map<EmployeeDto>(result.Resource));
                }

                return this.StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);
            }
            catch (TaskCanceledException ex)
            {
                return this.StatusCode(StatusCodes.Status504GatewayTimeout, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// This method is used to get the list of all the employees in aM family.
        /// </summary>
        /// <param name="token">
        /// Cancellation token to cancel the request.
        /// </param>
        /// <returns>
        /// List of all employees
        /// </returns>
        [HttpGet]
        [Route("get-all-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEmployeesAsync(
            CancellationToken token)
        {
            try
            {
                var result = await this._amBusiness.GetAllEmployees(token);

                if (!result.IsError)
                {
                    return this.StatusCode(StatusCodes.Status200OK, result.Resource.Select(e=>this._mapper.Map<EmployeeDto>(e)).ToList());
                }

                return this.StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);
            }
            catch (TaskCanceledException ex)
            {
                return this.StatusCode(StatusCodes.Status504GatewayTimeout, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

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
        /// true if success, false if any failure
        /// </returns>
        [HttpPut]
        [Route("update-employee-details/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEmployeeDetailsAsync
            ([FromBody] EmployeeDto empDto,
                [FromRoute][EmailAddress][Required] string email,
                CancellationToken token
            )
        {
            // Check if model state is valid
            if (!this.ModelState.IsValid)
            {
                // return bad request.
                return this.BadRequest(this.ModelState);
            }

            if (string.IsNullOrEmpty(email))
            {
                return this.BadRequest(AppConstants.InvalidEmailId);
            }

            try
            {
                var emp = this._mapper.Map<Employee>(empDto);

                var result = await this._amBusiness.UpdateEmployee(emp, email, token);

                if (!result.IsError)
                {
                    return this.StatusCode(StatusCodes.Status200OK, result.ErrorMessage);
                }

                return this.StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);
            }
            catch (TaskCanceledException ex)
            {
                return this.StatusCode(StatusCodes.Status504GatewayTimeout, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

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
        /// Status code indicating success or failure of the task.
        /// </returns>
        /// <remarks>
        /// OK (200) for successfully publish.
        /// Gateway Time out (504) for cancellation and
        /// Internal Server Error (500) for any other exceptions.
        /// </remarks>
        [HttpDelete]
        [Route("delete-employee/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveEmployeeAsync(
                [FromRoute][EmailAddress][Required] string email,
                CancellationToken token)
        {
            // Check if model state is valid
            if (!this.ModelState.IsValid)
            {
                // return bad request.
                return this.BadRequest(this.ModelState);
            }

            if (string.IsNullOrEmpty(email))
            {
                return this.BadRequest(AppConstants.InvalidEmailId);
            }

            try
            {
                var result = await this._amBusiness.RemoveEmployee(email, token);

                if (!result.IsError)
                {
                    return this.StatusCode(StatusCodes.Status200OK, result.ErrorMessage);
                }

                return this.StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);
            }
            catch (TaskCanceledException ex)
            {
                return this.StatusCode(StatusCodes.Status504GatewayTimeout, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

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
        /// Status code indicating success or failure of the task.
        /// </returns>
        /// <remarks>
        /// OK (200) for successfully publish.
        /// this.BadRequest for bad request error,
        /// Gateway Time out (504) for cancellation and
        /// Internal Server Error (500) for any other exceptions.
        /// </remarks>
        [HttpPatch]
        [Route("increase-salary/{amount}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> IncreaseSalaryAsync(
                [FromRoute][Range(1, 10000)] double amount,
                CancellationToken token)
        {
            // Check if model state is valid
            if (!this.ModelState.IsValid)
            {
                // return bad request.
                return this.BadRequest(this.ModelState);
            }

            try
            {
                var result = await this._amBusiness.IncreaseSalary(amount, token);

                if (!result.IsError)
                {
                    return this.StatusCode(StatusCodes.Status200OK, result.ErrorMessage);
                }

                return this.StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);

            }
            catch (TaskCanceledException ex)
            {
                return this.StatusCode(StatusCodes.Status504GatewayTimeout, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        #endregion
    }
}