using PruebaTecnica.Entities;
using PruebaTecnica.Repository.Services;

namespace PruebaTecnica.Business.Models;

public class EmployeeModel
{
    private readonly EmployeeService _employeeService;

    public EmployeeModel()
    {
        _employeeService = new EmployeeService();
    }

    public async Task<List<Employee>> GetAllEmployeesAsync()
    {
        var employees = await _employeeService.GetAllEmployeesAsync();
        foreach (var employee in employees)
        {
            employee.AnnualSalary = CalculateAnnualSalary(employee.Salary);
        }
        return employees;
    }

    public decimal CalculateAnnualSalary(decimal monthlySalary)
    {
        return monthlySalary * 12;
    }
}
