using System;

// Define a struct called Number
struct Number
{
    // Property Amount of type decimal
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type Number
        Number myNumber = new Number();

        // Assign an amount to the Amount property of the object
        myNumber.Amount = 123.45m;

        // Print the amount to the console
        Console.WriteLine("Amount: " + myNumber.Amount);
        Console.ReadLine();
    }
}
