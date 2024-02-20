using System;

namespace PolymorphismAssignmentSubmition
{
    //Define the Person class
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Method to say the name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
