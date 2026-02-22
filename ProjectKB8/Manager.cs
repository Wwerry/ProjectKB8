using System;

namespace ProjectKB8
{
    class Manager : Employee
    {
        public int KPI { get; set; }
        public string Project { get; set; }

        public override void PerformDuties()
        {
        }
    }
}