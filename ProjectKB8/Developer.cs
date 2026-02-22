using System;

namespace ProjectKB8
{
    class Developer : Employee
    {
        public string Stack { get; set; }
        public string Skill { get; set; }

        public Developer(string skill, string stack)
        {
            Skill = skill;
            Stack = stack;
        }

        public override void PerformDuties()
        {
            Console.WriteLine($"hello I am a Developer. My skill is {Skill} and my stack is {Stack}");
        }
    }
}