using System;
using System.Collections.Generic;

namespace ProjectKB8
{
    public class Department
    {
        public string Name { get; }

        private readonly List<Employee> employees = new List<Employee>();
        private readonly List<Client> clients = new List<Client>();
        private readonly List<IHallAccessible> humansInHall = new List<IHallAccessible>();
        private readonly List<IDevRoomAccessible> humansInDevRoom = new List<IDevRoomAccessible>();
        
        public Department(string name)
        {
            Name = name;
        }
        
        public void AddEmployee(Employee emp) => employees.Add(emp);
        public void AddClient(Client client) => clients.Add(client);
        public void RemoveEmployee(Employee emp) => employees.Remove(emp);
        public void RemoveClient(Client client) => clients.Remove(client);
        
        public void ShowHumansInHall()
        {
            Console.WriteLine($"\nКомната: Hall");
            Console.WriteLine("Люди в Hall:");
            foreach (var person in humansInHall) Console.WriteLine($"- {person.Name} (Тип: {person.GetType().Name})");;
        }
        
        public void ShowHumansInDevRoom()
        {
            Console.WriteLine($"\nКомната: DevRoom");
            Console.WriteLine("Люди в DevRoom:");
            foreach (var person in humansInDevRoom) Console.WriteLine($"- {person.Name} (Тип: {person.GetType().Name})");;
        }
        
        public void ShowAll()
        {
            Console.WriteLine($"\nДепартамент: {Name}");
            Console.WriteLine("Сотрудники:");
            foreach (var e in employees) e.PerformDuties();

            Console.WriteLine("Клиенты:");
            foreach (var c in clients) c.ShowInfo();

            Console.WriteLine("-------------------");
        }
    }
}
