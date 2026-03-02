using System;

namespace ProjectKB8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Департамент 1
            IDepartment salesDep = new Department("Работа с клиентами");

            salesDep.AddEmployee(new Manager(1, "Интернет-магазин", 21, "Костя", 9999));
            salesDep.AddEmployee(new Manager(1, "CRM система", 20, "Ольга", 9999));
            salesDep.AddClient(new Client("Ирина", "Кодим ООО"));
            salesDep.AddClient(new Client("Сергей", "ИП Иванов"));

            // Департамент 2
            IDepartment devDep = new Department("Разработка");

            devDep.AddEmployee(new Developer("крутой", "C# / .NET", 15, "Антоха", 9999));
            devDep.AddEmployee(new Developer("быстрый", "python", 16, "Вован", 9999));
            devDep.AddEmployee(new Manager(1, "ToDo", 17, "Колян", 9999));

            // Выводим оба департамента
            salesDep.Show();
            devDep.Show();
        }
    }
}