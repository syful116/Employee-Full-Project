using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectTeam04.Core.City.Query;
public record GetCityById(int Id) : IRequest<VmCity>;

public class GetCityByIdHandler : IRequestHandler<GetCityById, VmCity>
{

    private readonly ICityRepository _cityRepository;

    public GetCityByIdHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<VmCity> Handle(GetCityById request, CancellationToken cancellationToken)
    {
        return await _cityRepository.GetById(request.Id);
    }
}
