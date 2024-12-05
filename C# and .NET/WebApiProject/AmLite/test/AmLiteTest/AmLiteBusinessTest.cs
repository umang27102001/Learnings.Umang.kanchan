namespace AmLiteTest
{
    using AmLite.Abstractions.Result.RepositoryResult;
    using AmLite.Business;
    using AmLite.Repository;
    using AmLite.Repository.Models;
    using AutoFixture;
    using Moq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class AmLiteBusinessTest
    {
        private readonly IAmRepository _amRepository;
        private readonly IFixture _fixture;
        private readonly CancellationToken _token;

        public AmLiteBusinessTest()
        {
            this._amRepository = Mock.Of<IAmRepository>();
            this._fixture = new Fixture();
            this._token = CancellationToken.None;
        }

        #region AddEmployee.
        [Fact]
        public async Task GivenAddEmployee_WhenEmployeeAlreadyExists_ThenRetunErrorTrue()
        {
            // Arrange
            var employee = this._fixture.Create<Employee>();

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = false
                    }
                );
            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.AddEmployee(employee, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify 
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenAddEmployee_WhenRepositoryError_ThenRetunErrorTrue()
        {
            // Arrange
            var employee = this._fixture.Create<Employee>();

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = true
                    }
                );
            Mock.Get(this._amRepository)
                .Setup(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryResult
                    {
                        IsError = true
                    }
                );

            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.AddEmployee(employee, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify 
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenAddEmployee_WhenAddedSuccessfully_ThenRetunErrorFalse()
        {
            // Arrange
            var employee = this._fixture.Create<Employee>();

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = true
                    }
                );
            Mock.Get(this._amRepository)
                .Setup(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryResult
                    {
                        IsError = false
                    }
                );

            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.AddEmployee(employee, this._token);

            // Assert
            Assert.False(actual.IsError);

            // Verify 
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.AddEmployee(It.IsAny<Employee>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region GetEmployeeById.

        [Fact]
        public async Task GivenGetEmployeeById_WhenRepositoryError_ThenRetunErrorTrue()
        {
            // Arrange
            var email = "kanchan.uman@gamil.com";

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = true
                    }
                );

            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.GetEmployeeByEmailId(email, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify 
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenGetEmployeeById_WhenNoRepositoryError_ThenRetunErrorFalse()
        {
            // Arrange
            var email = "kanchan.uman@gamil.com";

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = false
                    }
                );

            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.GetEmployeeByEmailId(email, this._token);

            // Assert
            Assert.False(actual.IsError);

            // Verify 
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        #endregion

        #region GetAllEmployees.

        [Fact]
        public async Task GivenGetAllEmployees_WhenRepositoryError_TheReturnErrorTrue()
        {
            // Arrange
            Mock.Get(this._amRepository)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<List<Employee>>
                    {
                        IsError = true
                    }
                );

            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.GetAllEmployees(this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenGetAllEmployees_WhenNoRepositoryError_TheReturnErrorFalse()
        {
            // Arrange
            Mock.Get(this._amRepository)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<List<Employee>>
                    {
                        IsError = false
                    }
                );

            var target = new AmBusiness(this._amRepository);

            // Act
            var actual = await target.GetAllEmployees(this._token);

            // Assert
            Assert.False(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }

        #endregion

        #region UpdateEmployee.

        [Fact]
        public async Task GivenUpdateEmployee_WhenEmployeeDoesNotExist_ThenReturnErrorTrue()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            var email = "kanchan.umang@gmail.com";

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = true
                    }
                );

            // Actual
            var actual = await target.UpdateEmployee(emp, email, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenUpdateEmployee_WhenRepositoryError_ThenReturnErrorTrue()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            var email = "kanchan.umang@gmail.com";

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = false
                    }
                );

            Mock.Get(this._amRepository)
                .Setup(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryResult
                    {
                        IsError = true
                    }
                );
            // Actual
            var actual = await target.UpdateEmployee(emp, email, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenUpdateEmployee_WhenNoRepositoryError_ThenReturnErrorFalse()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            var email = "kanchan.umang@gmail.com";

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = false
                    }
                );

            Mock.Get(this._amRepository)
                .Setup(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryResult
                    {
                        IsError = false
                    }
                );
            // Actual
            var actual = await target.UpdateEmployee(emp, email, this._token);

            // Assert
            Assert.False(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.UpdateEmployee(It.IsAny<Employee>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region RemoveEmployee.

        [Fact]
        public async Task GivenRemoveEmployee_WhenEmployeeDoesNotExist_ThenReturnErrorTrue()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            var email = "kanchan.umang@gmail.com";

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = true
                    }
                );

            // Actual
            var actual = await target.RemoveEmployee(email, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenRemoveEmployee_WhenRepositoryError_ThenReturnErrorTrue()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            var email = "kanchan.umang@gmail.com";

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = false
                    }
                );

            Mock.Get(this._amRepository)
                .Setup(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryResult
                    {
                        IsError = true
                    }
                );
            // Actual
            var actual = await target.RemoveEmployee(email, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenRemoveEmployee_WhenNoRepositoryError_ThenReturnErrorFalse()
        {
            // Arrange
            var emp = this._fixture.Create<Employee>();

            var email = "kanchan.umang@gmail.com";

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<Employee>
                    {
                        IsError = false
                    }
                );

            Mock.Get(this._amRepository)
                .Setup(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryResult
                    {
                        IsError = false
                    }
                );

            // Actual
            var actual = await target.RemoveEmployee(email, this._token);

            // Assert
            Assert.False(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetEmployeeByEmailId(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.RemoveEmployee(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion

        #region IncreaseSalary.

        [Fact]
        public async Task GivenIncreaseSalary_WhenNoEmployeeExist_ThenReturnErrorTrue()
        {
            // Arrange
            double amount = 500;
            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<List<Employee>>
                    {
                        IsError = true
                    }
                );

            // Actual
            var actual = await target.IncreaseSalary(amount, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenIncreaseSalary_WhenRepositoryError_ThenReturnErrorTrue()
        {
            // Arrange
            var amount = 500;

            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<List<Employee>>
                    {
                        IsError = false
                    }
                );

            Mock.Get(this._amRepository)
                .Setup(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()))
                .Returns(
                    new RepositoryResult
                    {
                        IsError = true
                    }
                );


            // Actual
            var actual = await target.IncreaseSalary(amount, this._token);

            // Assert
            Assert.True(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GivenIncreaseSalary_WhenNoRepositoryError_ThenReturnErrorFalse()
        {
            // Arrange
            var amount = 500;
            var target = new AmBusiness(this._amRepository);

            Mock.Get(this._amRepository)
                .Setup(e => e.GetAllEmployees(It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                    new RepositoryOneResult<List<Employee>>
                    {
                        IsError = false
                    }
                );

            Mock.Get(this._amRepository)
                .Setup(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()))
                .Returns(
                    new RepositoryResult
                    {
                        IsError = false
                    }
                );

            // Actual
            var actual = await target.IncreaseSalary(amount, this._token);

            // Assert
            Assert.False(actual.IsError);

            // Verify
            Mock.Get(this._amRepository)
                .Verify(e => e.GetAllEmployees(It.IsAny<CancellationToken>()), Times.Once);

            Mock.Get(this._amRepository)
                .Verify(e => e.IncreaseSalary(It.IsAny<double>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        #endregion
    }
}