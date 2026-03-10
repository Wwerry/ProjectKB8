using System;

namespace ProjectKB8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Access check ===");

            Developer dev = new Developer("Strong", "C#", 21, "Steve", 90000);
            Manager manager = new Manager(10, "AI project", 24, "Alex", 150000);
            Client client = new Client("Jon", "Т-bank");
            
            Console.WriteLine("=== Department ===");
            Department department = new Department("CRM");
            department.AddEmployee(dev);
            department.AddEmployee(manager);
            department.AddClient(client);
            
            SecurityGate.EnterHall(client, department);
            SecurityGate.EnterHall(manager, department);
            SecurityGate.EnterDevRoom(manager, department);
            SecurityGate.EnterHall(manager, department);
            SecurityGate.EnterHall(dev, department);

            Console.WriteLine("");

            SecurityGate.EnterDevRoom(client, department); 
            SecurityGate.EnterDevRoom(dev, department);    
            
            Console.WriteLine("");
            
            department.ShowHumansInDevRoom();
            department.ShowHumansInHall();
            department.ShowAll();
        }
    }
}
