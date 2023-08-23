using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectTeam04.Core.Country.Command;

public record DeleteCountry(int id) : IRequest<VmCountry>;
public class DeleteCountryHandler : IRequestHandler<DeleteCountry, VmCountry>
{
    private readonly ICountryRepository _countryRepository;
    public DeleteCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<VmCountry> Handle(DeleteCountry request, CancellationToken cancellationToken)
    {
        return await _countryRepository.Delete(request.id);
    }
}