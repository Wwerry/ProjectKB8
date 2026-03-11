using System;
using System.Collections.Generic;

namespace ProjectKB8
{
    public class Department
    {
        public string Name { get; }

        private readonly List<Employee> employees = new List<Employee>();
        private readonly List<Client> clients = new List<Client>();
        private readonly List<IDevRoomAccessible> _humansInDevRoom = new List<IDevRoomAccessible>();
        private readonly List<IHallAccessible> _humansInHall = new List<IHallAccessible>();
        public List<IDevRoomAccessible> HumansInDevRoom => _humansInDevRoom;
        public List<IHallAccessible> HumansInHall => _humansInHall;
        
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
            Console.WriteLine($"\nRoom: Hall");
            Console.WriteLine("People in Hall:");
            foreach (var person in HumansInDevRoom) Console.WriteLine($"- {person.Name} (Type: {person.GetType().Name})");;
        }
        
        public void ShowHumansInDevRoom()
        {
            Console.WriteLine($"\nRoom: DevRoom");
            Console.WriteLine("People in DevRoom:");
            foreach (var person in HumansInDevRoom) Console.WriteLine($"- {person.Name} (Type: {person.GetType().Name})");;
        }
        
        public void ShowAll()
        {
            Console.WriteLine($"\nDepartment: {Name}");
            Console.WriteLine("Employees:");
            foreach (var e in employees) e.PerformDuties();

            Console.WriteLine("Clients:");
            foreach (var c in clients) c.ShowInfo();

            Console.WriteLine("-------------------");
        }
    }
}
