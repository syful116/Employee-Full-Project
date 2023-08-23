using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectTeam04.Core.Country.Query;
public record GetAllCountry() : IRequest<IEnumerable<VmCountry>>;
public class GetAllCountryHandler : IRequestHandler<GetAllCountry, IEnumerable<VmCountry>>
{
    private readonly ICountryRepository _countryRepository;
    public GetAllCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<IEnumerable<VmCountry>> Handle(GetAllCountry request, CancellationToken cancellationToken)
    {
        var result = await _countryRepository.GetList();
        return result;
    }
}