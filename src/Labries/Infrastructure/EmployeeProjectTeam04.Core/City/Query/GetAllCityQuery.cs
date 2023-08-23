using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.City.Query;
public record GetAllCity() : IRequest<IEnumerable<VmCity>>;
public class GetAllCityHandler : IRequestHandler<GetAllCity, IEnumerable<VmCity>>
{
    private readonly ICityRepository _cityRepository;
    public GetAllCityHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<IEnumerable<VmCity>> Handle(GetAllCity request, CancellationToken cancellationToken)
    {
        var result = await _cityRepository.GetList();
        return result;
    }
}