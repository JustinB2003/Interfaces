using System;

public interface IEmployee
{
    string Name { get; set; }
    int Id { get; set; }
    double Salary { get; set; }

    void GetEmployeeName();
    void GetEmployeeID();
    void GetSalary();
}

public interface IDepartment
{
    string DName { get; set; }
    string HOP { get; set; }

    void GetDepartmentName();
    void GetHOP();
}

public class Employee : IEmployee, IDepartment
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public string DName { get; set; }
    public string HOP { get; set; }

    public Employee(string name, int id, double salary, string dName, string hop)
    {
        Name = name;
        Id = id;
        Salary = salary;
        DName = dName;
        HOP = hop;
    }

    public void GetEmployeeName()
    {
        Console.WriteLine($"Employee Name: {Name}");
    }

    public void GetEmployeeID()
    {
        Console.WriteLine($"Employee ID: {Id}");
    }

    public void GetSalary()
    {
        Console.WriteLine($"Salary: {Salary}");
    }

    public void GetDepartmentName()
    {
        Console.WriteLine($"Department: {DName}");
    }

    public void GetHOP()
    {
        Console.WriteLine($"HOP: {HOP}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Lusukama S", 1, 35924.25, "IT", "Sipho Ndlovu");

        employee.GetEmployeeName();
        employee.GetEmployeeID();
        employee.GetSalary();
        employee.GetDepartmentName();
        employee.GetHOP();
    }
}
