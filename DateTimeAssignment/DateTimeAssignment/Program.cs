﻿using System;


namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the current date and time to the console
            Console.WriteLine("The current time is: " + DateTime.Now);
            //Ask the user for a number
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours: ");
            float answer = float.Parse(Console.ReadLine());
            //Print what time it will be in the mount of hours the user input
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}
