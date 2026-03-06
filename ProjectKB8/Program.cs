using System;

namespace ProjectKB8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Проверка доступа ===");

            Developer dev = new Developer("Сильный", "C#", 21, "Стив", 90000);
            Manager manager = new Manager(10, "AI проект", 24, "Алекс", 150000);

            dev.EnterDevRoom();

            manager.EnterHall();
            manager.EnterDevRoom();
        }
    }
}