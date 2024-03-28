using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("companies")]
public class CompaniesController : ControllerBase
{
    private static readonly List<Company> _companies = [];
    private readonly ILogger<CompaniesController> _logger;

    public CompaniesController(ILogger<CompaniesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_companies);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody]Company newCompany)
    {
        if(string.IsNullOrWhiteSpace(newCompany.Name))
        {
            throw new Exception("Company name can't be empty");
        }

        _companies.Add(newCompany);

        _logger.LogInformation("Company created {company}", newCompany);

        return Created(newCompany.Id.ToString(), newCompany);
    }
}

public class Company
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
}
