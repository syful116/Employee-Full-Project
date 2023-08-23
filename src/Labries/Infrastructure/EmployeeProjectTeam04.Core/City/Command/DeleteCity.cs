using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.City.Command;
public record DeleteCity (int id) : IRequest<VmCity>;
public class DeleteCityHandler : IRequestHandler<DeleteCity, VmCity>
{
    private readonly ICityRepository _cityRepository;
    public DeleteCityHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<VmCity> Handle(DeleteCity request, CancellationToken cancellationToken)
    {
        return await _cityRepository.Delete(request.id);
    }
}