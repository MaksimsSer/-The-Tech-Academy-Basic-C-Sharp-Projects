using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ask the user for their age
                Console.WriteLine("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                //Check if age is negative or zero
                if(age<=0)
                {
                    throw new ArgumentException("Age must be positive number.");
                }
                //Calculate the birth year
                int birthYear = DateTime.Now.Year - age;
                //Display the year the use was born
                Console.WriteLine($"You were born in the year {birthYear}");
            }
            catch (FormatException)
            {
                //Display error message for invalid input (non-integer)
                Console.WriteLine("Error: Please enter a vaild integer for age.");
            }
            catch (ArgumentException ex)
            {
                //Display error message for zero or negative age
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception)
            {
                //Display general error message for other exeptions
                Console.WriteLine("An error occurred. Please try again");
            }
            Console.ReadLine();
        }
    }
}
