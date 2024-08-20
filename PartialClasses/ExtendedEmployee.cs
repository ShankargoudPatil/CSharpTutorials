namespace PartialClasses;
public partial class  Employee
{
    public string GetEmployeeDetails() => $"Employee: {GetFullName()}";
    public  partial int GenerateEmployeeId()
    {
       return  EmpId = new Random().Next(1000, 10000);
    }
 
}

