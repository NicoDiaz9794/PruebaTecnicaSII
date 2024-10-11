using PruebaTecnica.Entities;
using System.Linq;
using System.Data;
using Newtonsoft.Json;

namespace PruebaTecnica.Repository.Services;

public class EmployeeService
{
    private readonly HttpClient _httpClient;

    public EmployeeService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Employee>> GetAllEmployeesAsync()
    {
        HttpClientHandler handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
        HttpClient client = new HttpClient(handler);
        var response = await client.GetStringAsync("https://hub.dummyapis.com/employee");

        var employees = JsonConvert.DeserializeObject<List<Employee>>(response);

        return employees;
    }
}