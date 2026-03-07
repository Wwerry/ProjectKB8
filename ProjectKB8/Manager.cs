using System;

namespace ProjectKB8
{
    public class Manager : Employee, IHallAccessible, IDevRoomAccessible
    {
        public int KPI { get; set; }
        public string Project { get; set; }
        public Manager(int kpi, string project, int age, string name, int salary) : base(age, name, salary)
        {
            KPI = kpi;
            Project = project;
        }

        public void EnterHall()
        {
            Console.WriteLine($"Manager {Name} entered the hall.");
        }

        public void EnterDevRoom()
        {
            Console.WriteLine($"Manager {Name} entered the dev room.");
        }
        
        public override void PerformDuties()
        {
            Console.WriteLine($"hello I am a Manager. I have a project names {Project} with KPI {KPI}");
        }
    }
}