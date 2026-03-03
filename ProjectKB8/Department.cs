using System;
using System.Collections.Generic;

namespace ProjectKB8
{
    public class Department
    {
        public string Name { get; }

        private readonly List<Employee> employees = new List<Employee>();
        private readonly List<Client> clients = new List<Client>();

        public Department(string name)
        {
            Name = name;
        }
        
        public void AddEmployee(Employee emp) => employees.Add(emp);
        public void AddClient(Client client) => clients.Add(client);

        public void Show()
        {
            Console.WriteLine($"\nОтдел: {Name}");
            Console.WriteLine("Сотрудники:");
            foreach (var e in employees) e.PerformDuties();

            Console.WriteLine("Клиенты:");
            foreach (var c in clients) c.ShowInfo();

            Console.WriteLine("-------------------");
        }
    }
}