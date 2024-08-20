namespace PartialClasses;

public partial class Employee
{
    public int EmpId { get; set; }
    public string FirstName { get; set; } = "John";
    public string LastName { get; set; } = "Roy";
    public string GetFullName() => $"{FirstName} {LastName}";

    public  partial int GenerateEmployeeId();
}
