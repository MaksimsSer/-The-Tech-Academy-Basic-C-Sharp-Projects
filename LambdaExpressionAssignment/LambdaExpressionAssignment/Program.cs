using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employeea.
            //At least two employess should have the first name "Joe"
            List<Emploee> campus = new List<Emploee>()
            {
            new Emploee() { Id= 1, firstName = "Joe", lastName = "Smith"},
            new Emploee() { Id= 2, firstName = "Sid", lastName = "Adams"},
            new Emploee() { Id= 3, firstName = "Jim", lastName = "Thomas"},
            new Emploee() { Id= 4, firstName = "Joe", lastName = "Ohara"},
            new Emploee() { Id= 5, firstName = "Greig", lastName = "Murray"},
            new Emploee() { Id= 6, firstName = "Don", lastName = "Dan"},
            new Emploee() { Id= 7, firstName = "Magda", lastName = "O'nill"},
            new Emploee() { Id= 8, firstName = "Stacie", lastName = "Barkley"},
            new Emploee() { Id= 9, firstName = "Andrejs", lastName = "Pekuns"},
            new Emploee() { Id= 9, firstName = "Alex", lastName = "K'Ohans"},
            };
            //USing a foreach loop, create a new list of all employees with the first name "Joe"#
            List<Emploee> joes = new List<Emploee>();
            foreach (Emploee emploee in campus)
            {
                if (emploee.firstName == "Joe")
                {
                    joes.Add(emploee);
                }
            }

            Console.WriteLine("Employees with first name Joe (using foreach loop):");
            foreach (var joe in joes)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.firstName} {joe.lastName}");
            }

            // Do the same thing again, but this time with a Lambda expression.
            List<Emploee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();

            Console.WriteLine("\nEmployees with first name Joe (using lambda expression):");
            foreach (var joe in joes2)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.firstName} {joe.lastName}");
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Emploee> bigId = campus.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (var employee in bigId)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.firstName} {employee.lastName}");
            }

            Console.ReadLine();

        }
    }
}
