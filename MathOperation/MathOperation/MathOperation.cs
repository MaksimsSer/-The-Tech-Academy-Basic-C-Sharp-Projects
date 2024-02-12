using System;


namespace MathOperation
{
    //Define a class named MathOperation
    class MathOperation
    {
        //Define a void method that takes two integers as parameters
        public void PerformMathOperation(int num1, int num2)
        {
            //Perform a math operation on the first integer
            //For demonstration, lets just add 10 to the first number
            int result = num1 + 10;

            // Display second integer to the screen
            Console.WriteLine($"The second integer is : {num2}");
        }
    }
}
