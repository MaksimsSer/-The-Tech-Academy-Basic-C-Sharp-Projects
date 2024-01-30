using System;
using System.Collections.Generic;

namespace AssignmentPart1
{
    class Program
    {
        static void Main()
        {
            //Define a one-dimensional array of strings
            string[] stringArray = {"Hello ", "Is it ", "What is ", "Best option " };

            //Asl the user to input some text
            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            //Loop to iterate through each string in the array and append user's text input 
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // Loop to print each string in the updated array
            Console.WriteLine("\nUpdated Array: ");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            //Infinite loop (before fixing)

            //while (true)
            //{
            //    Console.WriteLine("This is an infinite loop:");
            //}

            //Fixing the infinite loop
            Console.WriteLine("\nFixed Infinite Loop:");
            Console.WriteLine("This is not an infinite loop anymore!");

            //Loop using the "less than" (<) opertor
            Console.WriteLine("\nLoop with < operator:");
            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine("Iteration with < operator: " + i);
            }

            //Loop using the "less than or equal to" (<=) operator
            Console.WriteLine("\nLoop with <= operator:");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Iteration with <= operator " + i);
            }


            List<string> uniqueList = new List<string> { "apple", "banana", "orange", "grape", "kiwi" };

            Console.WriteLine("Enter text to search for in the list:");
            string searchText = Console.ReadLine();

            bool foundMatch = false;

            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i].Contains(searchText))
                {
                    Console.WriteLine($"Match found at index {i}: {uniqueList[i]}");
                    foundMatch = true;
                    break; // Stop the loop once a match is found
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine($"The text '{searchText}' is not on the list.");
            }

            //Wait for user input before closing the console window
            Console.ReadLine();



            List<string> nameList = new List<string> { "John", "Jane", "Bob", "Jane", "Alice" };

            Console.WriteLine("Enter a name to search for in the list:");
            string searchName = Console.ReadLine();

            bool foundMatch1 = false;

            for (int j = 0; j < nameList.Count; j++)
            {
                if (nameList[j].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {j}: {nameList[j]}");
                    foundMatch1 = true;
                    // If you want to stop after the first match, you can break the loop here:
                    // break;
                }
            }

            if (!foundMatch1)
            {
                Console.WriteLine($"The name '{searchName}' is not on the list.");
            }

            
            // Create a list of strings with at least two identical strings
            List<string> stringList = new List<string> { "A", "B", "C", "D", "C" };

            // Create a HashSet to keep track of unique strings
            HashSet<string> uniqueStrings = new HashSet<string>();

            // Create a foreach loop to evaluate each item in the list
            foreach (string item in stringList)
            {
                // Check if the item is already in the HashSet
                if (uniqueStrings.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    // If the item is not in the HashSet, add it
                    uniqueStrings.Add(item);
                    Console.WriteLine($"{item} - this item is unique");
                }
            }

            Console.ReadLine();

        }
    }
}
