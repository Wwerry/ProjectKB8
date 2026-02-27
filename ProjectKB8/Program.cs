using System;
using System.Collections.Generic;

namespace ProjectKB8
{
    public class Program
    {
        public static void Main()
        {
            Developer Dev = new Developer("крутой", "python", 17, "Антоха", 50000);
            Dev.PerformDuties();
            
            Manager Man = new Manager(1, "умный дом", 19, "Колян", 10000);
            Man.PerformDuties();

            Department Dep = new Department();
            Dep.AddEmployee(Dev);
            Dep.AddEmployee(Man);
            
            Console.WriteLine(" ");
            
            Dep.DeleteEmployee(Man);
            Dep.DisplayInfo();
        }
    }
}