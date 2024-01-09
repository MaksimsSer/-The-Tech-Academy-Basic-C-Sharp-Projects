using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolWhileDostatement
{
    class Program
    {
        static void Main()
        {
            //Boolean comparison using while loop
            Console.WriteLine("Boolean comparison using while loop:");
            int number = 7;

            while (number < 15) //While the number is less than 5
            {
                Console.WriteLine($"Number is {number}");
                number++; //Insert number by 1
            }
            Console.WriteLine();


            //Boolean comparison using do while loop
            Console.WriteLine("Boolean comparison using do while loop:");
            int counter = 0;

            do
            {
                Console.WriteLine($"Counter is {counter}");
                counter++; //Increment counter by 1
            }
            while (counter < 5); // Do it qt least once while the counter is less than 5
            Console.ReadLine();
        }
    }
}
