using System;

namespace ProjectKB8
{
    abstract class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        // конструктор
        public Employee(int age, string name, int salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }

        public abstract void PerformDuties();
    }
}