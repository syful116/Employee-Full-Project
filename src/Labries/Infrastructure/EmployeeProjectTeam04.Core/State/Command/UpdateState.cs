using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.State.Command;
public record UpdateState(int Id, VmState VmState) : IRequest<VmState>;
public class UpdateStateHandler : IRequestHandler<UpdateState, VmState>
{

    private readonly IStateRepository _stateRepository;
    private readonly IMapper _mapper;

    public UpdateStateHandler(IStateRepository stateRepository, IMapper mapper)
    {
        _stateRepository = stateRepository;
        _mapper = mapper;
    }
    public async Task<VmState> Handle(UpdateState request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.State>(request.VmState);
        return await _stateRepository.Update(request.Id, data);
    }
}