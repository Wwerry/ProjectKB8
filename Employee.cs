abstract class Employee
{
    public int Age { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public abstract void PerformDuties();
}