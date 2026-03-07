using System;

namespace ProjectKB8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Проверка доступа ===");

            Developer dev = new Developer("Сильный", "C#", 21, "Steve", 90000);
            Manager manager = new Manager(10, "AI проект", 24, "Alex", 150000);
            Client client = new Client("Jon", "Т-банк");
            
            SecurityGate.CheckDevRoomAccess(dev);
            SecurityGate.CheckHallAccess(dev);
            
            SecurityGate.CheckDevRoomAccess(manager);
            SecurityGate.CheckHallAccess(manager);
            
            SecurityGate.CheckDevRoomAccess(client);
            SecurityGate.CheckHallAccess(client);
        }
    }
}