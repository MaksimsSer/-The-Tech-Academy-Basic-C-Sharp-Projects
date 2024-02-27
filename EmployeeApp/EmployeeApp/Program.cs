using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating instances of Employee class
            Employee emp1 = new Employee(1, "John", "Smith");
            Employee emp2 = new Employee(2, "Jane", "Doe");
            Employee emp3 = new Employee(1, "John", "Smith"); //Creating a duplicate of emp1

            //Testing the overloaded "==" operator 
            Console.WriteLine("Comparison Results: ");
            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}"); // False because the Id of emp1 (1) is not equal to the Id of emp2
            Console.WriteLine($"emp1 == emp3: {emp1 == emp3}"); // True because both emp1 and emp3 have the same Id (1).

            //Testing the overload "!=" operator
            Console.WriteLine($"emp1 != emp2: {emp1 != emp2}"); //True because emp1 and emp2 have different Ids.
            Console.WriteLine($"emp1 != emp3: {emp1 != emp3}"); // False because emp1 and emp3 have the same Id.

            Console.ReadLine();
        } 
    }
}
