using AutoMapper;

using EmployeeProjectTeam04.Services.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmployeeProjectTeam04.Core.Mapper;
public class CommonMapper : Profile
{
    public CommonMapper()
    {
        CreateMap<VmDepartment,Model.Entity. Department>().ReverseMap();
        CreateMap<VmCountry, Model.Entity.Country>().ReverseMap();
        CreateMap<VmState, Model.Entity.State>().ReverseMap();
       CreateMap<VmCity,Model.Entity. City>().ReverseMap();


    }
}