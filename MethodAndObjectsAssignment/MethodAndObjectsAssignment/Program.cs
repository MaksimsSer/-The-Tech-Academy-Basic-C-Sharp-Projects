using System;

namespace MethodAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inside of thhe Main method, instantiate and initialize an Employoee object with 
            //the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
