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
            
            Department department = new Department("CRM");
            department.AddEmployee(dev);
            department.AddEmployee(manager);
            department.AddClient(client);

            Console.WriteLine("");
            Console.WriteLine("=== Разрешённый доступ ===");

            SecurityGate.EnterHall(client, department);
            SecurityGate.EnterHall(manager, department);
            SecurityGate.EnterDevRoom(dev, department);

            Console.WriteLine("");
            Console.WriteLine("=== Перемещение ===");

            SecurityGate.EnterDevRoom(manager, department);
            SecurityGate.EnterHall(manager, department);
        
            Console.WriteLine("");
            Console.WriteLine("=== Запрещённый доступ ===");

            SecurityGate.EnterHall(dev, department); 
            SecurityGate.EnterDevRoom(client, department);    
                       
            Console.WriteLine("");

            department.ShowHumansInDevRoom();
            department.ShowHumansInHall();
            department.ShowAll();
        }
    }
}
