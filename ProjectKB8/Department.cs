using System;
using System.Collections.Generic;

namespace ProjectKB8 
{
    class Department
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void AddEmployee(Employee employee) 
        {
            Employees.Add(employee);
        }
        
        public void DeleteEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        
        public void DisplayInfo()
        {
            foreach (var employee in Employees)
            {
                employee.PerformDuties();
            }
        }
    }
}