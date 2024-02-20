using System;


namespace AbstractClassesAssignment
{
   public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Give it the method SayName();
        public abstract void SayName();
    }
}
