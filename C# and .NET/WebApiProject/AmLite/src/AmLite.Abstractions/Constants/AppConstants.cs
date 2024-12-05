using System.Diagnostics.CodeAnalysis;

namespace AmLite.Abstractions.Constants
{
    /// <summary>
    /// All constants go here.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class AppConstants
    {
        public const string AddEmployeeSuccess = "AmLiteEmployee added successfully!";

        public const string AddEmployeeFailure = "AmLiteEmployee already exists!";

        public const string EmployeeDoesNotExist = "AmLiteEmployee with given email does not exist!";

        public const string NoEmployeeFound = "No employee found!";

        public const string UpdateEmployeeDetailsSuccess = "AmLiteEmployee details updated successfully!";

        public const string UpdateEmployeeDetailsFailure = "AmLiteEmployee details update failed!";

        public const string RemoveEmployeeSuccess = "AmLiteEmployee removed successfully!!";

        public const string RemoveEmployeeFailure = "AmLiteEmployee removal failed!!";

        public const string SalaryIncreasedSuccessfully = "Salary increased Successfully";

        public const string SalaryIncreaseFailure = "Salary could not be increased";

        public const string InvalidEmailId = "Empty or invalid email id!!";

        public const string EmployeeAlreadyExists = "Employee with this email already exists!";
    }
}