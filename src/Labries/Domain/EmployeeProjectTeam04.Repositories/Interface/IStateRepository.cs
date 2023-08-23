﻿using EmployeeProjectTeam04.Model.Entity;
using EmployeeProjectTeam04.Services.Model;
using EmployeeProjectTeam04.Shared.CommonRepository;

namespace EmployeeProjectTeam04.Repositories.Interface;

public interface IStateRepository : IRepository<State, VmState, int>
{

}
