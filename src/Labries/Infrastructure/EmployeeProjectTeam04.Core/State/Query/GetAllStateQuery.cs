using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.State.Query;
public record GetAllState() : IRequest<IEnumerable<VmState>>;
public class GetAllStateHandler : IRequestHandler<GetAllState, IEnumerable<VmState>>
{
    private readonly IStateRepository _stateRepository;
    public GetAllStateHandler(IStateRepository stateRepository)
    {
        _stateRepository = stateRepository;
    }

    public async Task<IEnumerable<VmState>> Handle(GetAllState request, CancellationToken cancellationToken)
    {
        var result = await _stateRepository.GetList();
        return result;
    }
}