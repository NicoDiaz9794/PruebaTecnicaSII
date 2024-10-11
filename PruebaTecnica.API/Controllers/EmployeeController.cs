using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Business.Models;
namespace PruebaTecnica.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeModel _employeeModel;

    public EmployeeController()
    {
        _employeeModel = new EmployeeModel();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var employees = await _employeeModel.GetAllEmployeesAsync();
        return Ok(employees);
    }
}