using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.City.Command;
public record UpdateCity(int Id, VmCity VmCity) : IRequest<VmCity>;
public class UpdateCityHandler : IRequestHandler<UpdateCity, VmCity>
{

    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public UpdateCityHandler(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }
    public async Task<VmCity> Handle(UpdateCity request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.City>(request.VmCity);
        return await _cityRepository.Update(request.Id, data);
    }
}