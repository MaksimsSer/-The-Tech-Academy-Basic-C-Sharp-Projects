using System;


namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathOperation class
            MathOperation mathOperation = new MathOperation();
            //Call the method in the class, passing in two numbers
            mathOperation.PerformMathOperation(5, 8);
            //Call the method in the class, specifying the parameters
            mathOperation.PerformMathOperation(num1: 8, num2: 10);
            //Keep the console open untill a key is pressed
            Console.ReadKey();
        }
    }
}
