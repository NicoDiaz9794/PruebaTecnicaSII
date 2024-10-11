namespace PruebaTecnica.Entities;

public class Employee
{
    public int id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ContactNumber { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Dob { get; set; }
    public decimal Salary { get; set; }
    public decimal AnnualSalary { get; set; }
    public string Address { get; set; } = string.Empty;
}