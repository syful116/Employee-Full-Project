using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectTeam04.Core.State.Command;
public record DeleteState(int id) : IRequest<VmState>;
public class DeleteStateHandler : IRequestHandler<DeleteState, VmState>
{
    private readonly IStateRepository _stateRepository;

    public DeleteStateHandler(IStateRepository stateRepository)
    {
        _stateRepository = stateRepository;
    }

    
    public async Task<VmState> Handle(DeleteState request, CancellationToken cancellationToken)
    {
        return await _stateRepository.Delete(request.id);
    }
}