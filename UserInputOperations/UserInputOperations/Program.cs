using System;


namespace UserInputOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user
            Console.WriteLine("Enter a number");
            double userInput = Convert.ToDouble(Console.ReadLine());

            //Multiplies the input by 50 and prints the result
            double multipliedResult = userInput * 50;
            Console.WriteLine($"Input multiplied by 50: { multipliedResult }");

            // Adds 25 to the input and prints the result
            double addedResult = userInput + 25;
            Console.WriteLine($"Input added by 25: { addedResult }");

            //Devides the input by 12.5 and prints the result
            double dividedResult = userInput / 12.5;
            Console.WriteLine($"Input divided by 12.5: {dividedResult}");

            //Checks if the input is greater than 50 and pprints true/false
            bool isGreaterThan50 = userInput > 50;
            Console.WriteLine($"Is input greater than 50? {isGreaterThan50}");

            //Devides the input by 7 and prints the reminder
            double remainder = userInput % 7;
            Console.WriteLine($"Remainder of input divided by 7: {remainder}");

            Console.ReadLine(); //Keeps the console open
        }
    }
}
