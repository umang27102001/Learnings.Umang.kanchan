namespace AmLite.Api
{
    using AmLite.Abstractions.Models;
    using AmLite.Repository.Models;
    using AutoMapper;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Defines an automapper profile to condigure Automapper for aMLite
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Employee, EmployeeDto>().ReverseMap();

        }
    }
}