using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {


    }
}

class Department 
{
    public List<Employee> Employees { get; set; } = new List<Employee>();
    public void addEmployee(Employee employee) 
    {
    }
    public void deleteEmployee(Employee employee) { }
    public void displayInfo() { }


}
abstract class Employee
{
    public int Age { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public abstract void PerformDuties();
}
class Manager : Employee
{
    public int KPI { get; set; }
    public string Project { get; set; }
    public override void PerformDuties() { }
}

class Developer : Employee
{
    public string Stack { get; set; }
    public string Skill { get; set; }
    public override void PerformDuties() { }
}

