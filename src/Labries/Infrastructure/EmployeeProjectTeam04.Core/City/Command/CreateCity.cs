using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectTeam04.Core.City.Command;
public record CreateCity(VmCity VmCity) : IRequest<VmCity>;

public class CreateCityHandler : IRequestHandler<CreateCity, VmCity>
{

    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;
    public CreateCityHandler(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }

    public async Task<VmCity> Handle(CreateCity request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.City>(request.VmCity);
        return await _cityRepository.Add(data);
    }
}
