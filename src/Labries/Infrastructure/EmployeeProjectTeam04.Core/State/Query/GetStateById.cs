using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.State.Query;
public   record GetStateById(int Id) : IRequest<VmState>;

public class GetStateByIdHandler : IRequestHandler<GetStateById, VmState>
{

    private readonly IStateRepository _stateRepository;

    public GetStateByIdHandler(IStateRepository stateRepository)
    {
        _stateRepository = stateRepository;
    }

    public async Task<VmState> Handle(GetStateById request, CancellationToken cancellationToken)
    {
        return await _stateRepository.GetById(request.Id);
    }
}