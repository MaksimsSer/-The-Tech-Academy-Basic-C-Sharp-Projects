using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get details for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate:");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter hours worked per week:");
            double hoursWorkedPerWeek1 = Convert.ToDouble(Console.ReadLine());

            // Get details for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate:");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter hours worked per week:");
            double hoursWorkedPerWeek2 = Convert.ToDouble(Console.ReadLine());

            // Calculate annual salary for each person
            double annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52; // 52 weeks in a year
            double annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            // Print annual salaries
            Console.WriteLine("Annual salary of Person 1: £" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: £" + annualSalary2);

            // Check if Person 1 makes more money than Person 2
            bool person1EarnsMore = annualSalary1 > annualSalary2;

            // Print the comparison result
            Console.WriteLine("Person 1 makes more money than Person 2: " + person1EarnsMore);

            Console.ReadLine(); // Keeps the console window open
        }
    }
}