using System;


namespace PolymorphismAssignmentSubmition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiate an Employee object
            Employee employee = new Employee {FirstName = "John", LastName = "Smith" };

            //Call the SayName method of Employee object
            employee.SayName();

            //Use polymorphism to create an object of type IQuittable
            // and call thw Quit on it
            IQuittable quittable = employee; //Polymorphism
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
