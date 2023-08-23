using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectTeam04.Core.Country.Command;
public record CreateCountry(VmCountry VmCountry) : IRequest<VmCountry>;
public class CreateCountryHandler : IRequestHandler<CreateCountry, VmCountry>
{

    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;
    public CreateCountryHandler(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public async Task<VmCountry> Handle(CreateCountry request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.Country>(request.VmCountry);
        return await _countryRepository.Add(data);
    }
}
