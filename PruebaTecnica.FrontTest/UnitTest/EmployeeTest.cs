using PruebaTecnica.Business.Models;

namespace PruebaTecnica.FrontTest.Employee;

public class EmployeeTest
{
    [Fact]
    public void CalculateAnnualSalary_ReturnsCorrectValue()
    {
        // Arrange
        EmployeeModel employeeModel = new EmployeeModel();
        decimal monthlySalary = 1000m;

        // Act
        var annualSalary = employeeModel.CalculateAnnualSalary(monthlySalary);

        // Assert
        Assert.Equal(12000m, annualSalary);
    }
}
