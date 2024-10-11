using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Front.Models;

namespace PruebaTecnica.Front.Controllers;

public class EmployeeController : Controller
{
    private readonly IConfiguration _configuration;

    public EmployeeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        var apiUrl = _configuration["APISettings:URLApi"];

        EmployeeViewModel vm = new EmployeeViewModel() {
            urlAPI = apiUrl
        };

        return View(vm);
    }
}