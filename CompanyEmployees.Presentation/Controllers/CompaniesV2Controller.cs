using Asp.Versioning;
using CompanyEmployees.Presentation.ActionFilters;
using CompanyEmployees.Presentation.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace CompanyEmployees.Presentation.Controllers;

[ApiVersion("2.0")]
[Route("api/{v:apiversion}/companies")]
[ApiExplorerSettings(GroupName = "v2")]
[ApiController]
public class CompaniesV2Controller : ControllerBase
{
    private readonly IServiceManager _service;
    public CompaniesV2Controller(IServiceManager service) => _service = service;
    [HttpGet]
    public async Task<IActionResult> GetCompanies()
    {
        var companies = await _service.CompanyService.GetAllCompaniesAsync(trackChanges: false);

        var companiesV2 = companies.Select(x => $"{x.Name}  V2");

        return Ok(companiesV2);
    }

}
