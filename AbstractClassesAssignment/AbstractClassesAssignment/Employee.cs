using System;

namespace AbstractClassesAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {firstName} {lastName}");
        }
    }
}
