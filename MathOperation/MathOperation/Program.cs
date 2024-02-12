using System;


namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathOperation class
            MathOperation mathOperation = new MathOperation();
            //Call the method in the class, specifying parametres by name
            mathOperation.PerformMathOperation(firstNumber: 5, secondNumber: 8);
            mathOperation.PerformMathOperation(firstNumber: 2, secondNumber: 10);
            //Keep the console open untill a key is pressed
            Console.ReadLine();
        }
    }
}
