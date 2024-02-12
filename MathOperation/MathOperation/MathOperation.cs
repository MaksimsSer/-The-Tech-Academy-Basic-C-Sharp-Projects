using System;


namespace MathOperation
{
    //Define a class named MathOperation
    class MathOperation
    {
        //Define a void method that takes two integers as parameters
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            //Perform a math operation on the first integer
            //For demonstration, lets just add 10 to the first number
            int result = firstNumber + 10;

            // Display second integer to the screen
            Console.WriteLine($"The second integer is : {secondNumber}");
        }
    }
}
