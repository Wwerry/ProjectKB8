using System;

namespace ProjectKB8
{
    class Manager : Employee
    {
        public int KPI { get; set; }
        public string Project { get; set; }
        public Manager(int kpi, string project, int age, string name, int salary) : base(age, name, salary)
        {
            KPI = kpi;
            Project = project;
        }
        
        public override void PerformDuties()
        {
            Console.WriteLine($"hello I am a Manager. I have a project names {Project} with KPI {KPI}");
        }
    }
}