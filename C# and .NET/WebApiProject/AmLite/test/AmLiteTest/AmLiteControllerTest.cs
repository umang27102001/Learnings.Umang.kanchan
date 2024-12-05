namespace AmLiteTest
{
    using AmLite.Abstractions.Models;
    using AmLite.Abstractions.Result.TransactionResult;
    using AmLite.Api.Controllers;
    using AmLite.Business;
    using AmLite.Repository.Models;
    using AutoFixture;
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Moq;

    /// <summary>
    /// This class contains Unit tests for AmLiteController.
    /// </summary>
    public class AmLiteControllerTest
    {
        #region Dependencies.
        private readonly IAmBusiness _amBusiness;
        private readonly IFixture _fixture;
        private readonly IMapper _mapper;
        private readonly CancellationToken _token;
        #endregion

        #region Constructor.
        public AmLiteControllerTest()
        {
            this._amBusiness = Mock.Of<IAmBusiness>();
            this._mapper = Mock.Of<IMapper>();
            this._fixture = new Fixture();
            this._token = CancellationToken.None;
        }
        #endregion

        #region AddEmployeeAsync.
        [Fact]
        public async Task GivenValidBodyAddEmployeeAsync_WhenBusinessError_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();

            Mock.Get(this._amBusiness)
                .Setup(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = true,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.AddEmployeeAsync(empDto, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenValidBody_WhenAddEmployeeAsync_ThenReturnStatusCode200Ok()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();

            Mock.Get(this._amBusiness)
                .Setup(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = false,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.AddEmployeeAsync(empDto, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status200OK, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsTaskCanceledException_WhenAddEmployeeAsync_ThenReturnStatus504GatewayTimeout()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var taskCanceledException = new TaskCanceledException();

            Mock.Get(this._amBusiness)
                .Setup(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(taskCanceledException);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.AddEmployeeAsync(empDto, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status504GatewayTimeout, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsException_WhenAddEmployeeAsync_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var exception = new Exception();

            Mock.Get(this._amBusiness)
                .Setup(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.AddEmployeeAsync(empDto, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region GetEmployeeByIdAsync.

        [Fact]
        public async Task GivenInvalidEmailId_WhenGetEmployeeByEmailIdAsync_ThenReturn400BadRequest()
        {
            // Arrange
            var email = string.Empty;

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetEmployeeByEmailIdAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status400BadRequest, ((ObjectResult)actual).StatusCode);
        }

        [Fact]
        public async Task GivenValidEmailId_WhenBusinessError_ThenReturnStatusCode500InternelServerError()
        {
            // Arrange
            var email = "kanchan.umag@gmail.com";

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new OneResult<Employee>
                    {
                        IsError = true,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetEmployeeByEmailIdAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenValidEmailId_WhenGetEmployeeByEmailIdAsync_ThenReturnStatusCode200OK()
        {
            // Arrange
            var email = "kanchan.umag@gmail.com";

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new OneResult<Employee>
                    {
                        IsError = false,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetEmployeeByEmailIdAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status200OK, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsTaskCanceledException_WhenGetEmployeeByEmailIdAsync_ThenReturnStatus504GatewayTimeout()
        {
            // Arrange
            var email = "kanchan.umag@gmail.com";
            var taskCanceledException = new TaskCanceledException();

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(taskCanceledException);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetEmployeeByEmailIdAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status504GatewayTimeout, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsException_WhenGetEmployeeByEmailIdAsync_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var email = "kanchan.umag@gmail.com";
            var exception = new Exception();

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetEmployeeByEmailIdAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region GetAllEmployeesAsync.

        [Fact]
        public async Task GivenGetAllEmployeesAsync_WhenBusinessError_ThenReturnStatus500InternalServerError()
        {
            // Arrange
            Mock.Get(this._amBusiness)
                .Setup(e => e.GetAllEmployees(this._token))
                .ReturnsAsync(
                    new OneResult<List<Employee>>
                    {
                        IsError = true,
                    }
                );
            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetAllEmployeesAsync(this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenGetAllEmployeesAsync_WhenNoBusinessError_ThenReturnStatus200OK()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            Mock.Get(this._mapper)
                .Setup(e => e.Map<EmployeeDto>(It.IsAny<Employee>()))
                .Returns(It.IsAny<EmployeeDto>());

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new OneResult<List<Employee>>
                    {
                        Resource = new List<Employee> { emp },
                        IsError = false,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetAllEmployeesAsync(this._token);

            // Assert
            Assert.Equal(StatusCodes.Status200OK, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsTaskCanceledException_WhenGetAllEmployeesAsync_ThenReturnStatus504GatewayTimeout()
        {
            // Arrange
            var taskCanceledException = new TaskCanceledException();

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ThrowsAsync(taskCanceledException);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetAllEmployeesAsync(this._token);

            // Assert
            Assert.Equal(StatusCodes.Status504GatewayTimeout, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsException_WhenGetAllEmployeesAsync_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var exception = new Exception();

            Mock.Get(this._amBusiness)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.GetAllEmployeesAsync(this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region UpdateEmployeeDetailsAsync.

        [Fact]
        public async Task GivenUpdateEmployeeDetailsAsync_WhenInvalidEmail_ThenReturn400BadRequest()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = string.Empty;

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.UpdateEmployeeDetailsAsync(empDto, email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status400BadRequest, ((ObjectResult)actual).StatusCode);
        }

        [Fact]
        public async Task GivenUpdateEmployeeDetailsAsync_WhenBusinessError_ThenReturnStatus500InternalServerError()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";

            Mock.Get(this._amBusiness)
                .Setup(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = true,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.UpdateEmployeeDetailsAsync(empDto, email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenUpdateEmployeeAsync_WhenNoBusinessError_ThenReturnStatus200OK()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";

            Mock.Get(this._amBusiness)
                .Setup(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = false,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.UpdateEmployeeDetailsAsync(empDto, email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status200OK, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsTaskCanceledException_WhenUpdateEmployeeDetailsAsync_ThenReturnStatus504GatewayTimeout()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";
            var taskCanceledException = new TaskCanceledException();

            Mock.Get(this._amBusiness)
                .Setup(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(taskCanceledException);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.UpdateEmployeeDetailsAsync(empDto, email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status504GatewayTimeout, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsException_WhenUpdateEmployeeDetailsAsync_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";
            var exception = new Exception();

            Mock.Get(this._amBusiness)
                .Setup(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.UpdateEmployeeDetailsAsync(empDto, email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region RemoveEmployeeAsync.

        [Fact]
        public async Task GivenRemoveEmployeeAsync_WhenInvalidEmail_ThenReturn400BadRequest()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = string.Empty;

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.RemoveEmployeeAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status400BadRequest, ((ObjectResult)actual).StatusCode);
        }

        [Fact]
        public async Task GivenRemoveEmployeeAsync_WhenBusinessError_ThenReturnStatus500InternalServerError()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";

            Mock.Get(this._amBusiness)
                .Setup(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = true,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.RemoveEmployeeAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenRemoveEmployeeAsync_WhenNoBusinessError_ThenReturnStatus200OK()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";

            Mock.Get(this._amBusiness)
                .Setup(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = false,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.RemoveEmployeeAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status200OK, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsTaskCanceledException_WhenRemoveEmployeeAsync_ThenReturnStatus504GatewayTimeout()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";
            var taskCanceledException = new TaskCanceledException();

            Mock.Get(this._amBusiness)
                .Setup(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(taskCanceledException);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.RemoveEmployeeAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status504GatewayTimeout, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsException_WhenRemoveEmployeeAsync_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var empDto = this._fixture.Create<EmployeeDto>();
            var email = "kanchan.umanh@gmail.com";
            var exception = new Exception();

            Mock.Get(this._amBusiness)
                .Setup(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.RemoveEmployeeAsync(email, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region IncreaseSalaryAsync.

        [Fact]
        public async Task GivenIncreaseSalaryAsync_WhenBusinessError_ThenReturnStatus500InternalServerError()
        {
            // Arrange
            double amount = 500;

            Mock.Get(this._amBusiness)
                .Setup(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = true,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.IncreaseSalaryAsync(amount, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenIncreaseSalaryAsync_WhenNoBusinessError_ThenReturnStatus200OK()
        {
            // Arrange
            var amount = 500;

            Mock.Get(this._amBusiness)
                .Setup(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new Result
                    {
                        IsError = false,
                    }
                );

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.IncreaseSalaryAsync(amount, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status200OK, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsTaskCanceledException_WhenIncreaseSalaryAsync_ThenReturnStatus504GatewayTimeout()
        {
            // Arrange
            var amount = 500;
            var taskCanceledException = new TaskCanceledException();

            Mock.Get(this._amBusiness)
                .Setup(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(taskCanceledException);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.IncreaseSalaryAsync(amount, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status504GatewayTimeout, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenThrowsException_WhenIncreaseSalaryAsync_ThenReturnStatusCode500InternalServerError()
        {
            // Arrange
            var amount = 500;
            var exception = new Exception();

            Mock.Get(this._amBusiness)
                .Setup(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            var target = new AmLiteController(this._amBusiness, this._mapper);

            // Act
            var actual = await target.IncreaseSalaryAsync(amount, this._token);

            // Assert
            Assert.Equal(StatusCodes.Status500InternalServerError, ((ObjectResult)actual).StatusCode);

            // Verify
            Mock.Get(this._amBusiness)
                .Verify(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion
    }
}