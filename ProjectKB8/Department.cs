using System;
using System.Collections.Generic;

namespace ProjectKB8 
{
    class Department
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void addEmployee(Employee employee) {}
        public void deleteEmployee(Employee employee) {}
        public void displayInfo() {}
    }
}