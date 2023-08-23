using AutoMapper;
using EmployeeProjectTeam04.Infrastructure.DatabaseContext;
using EmployeeProjectTeam04.Model.Entity;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using EmployeeProjectTeam04.Shared.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectTeam04.Repositories.Base;
public class StateRepository : RepositoryBase<State, VmState, int>, IStateRepository
{
    public StateRepository(IMapper mapper, EmploymentDbContext dbContext) : base(mapper, dbContext)
    {
    }


}
