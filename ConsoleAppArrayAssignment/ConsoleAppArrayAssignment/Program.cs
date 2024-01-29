using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main()
        {
            // Create a one-dimensional Array of strings
            string[] stringArray = { "Apple", "Banana", "Orange", "Grapes", "Mango" };

            // Ask the user to select an index of the Array
            Console.WriteLine("Select an index for the string array:");
            int stringIndex = GetIndex(stringArray.Length);

            // Display the string at the selected index
            DisplayAtIndex(stringArray, stringIndex);

            // Create a one-dimensional Array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index of the Array
            Console.WriteLine("\nSelect an index for the integer array:");
            int intIndex = GetIndex(intArray.Length);

            // Display the integer at the selected index
            DisplayAtIndex(intArray, intIndex);

            // Create a list of strings
            List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

            // Ask the user to select an index of the list
            Console.WriteLine("\nSelect an index for the string list:");
            int listIndex = GetIndex(stringList.Count);

            // Display the content at the selected index
            DisplayAtIndex(stringList, listIndex);

            Console.ReadLine();
        }

        // Function to get a valid index from the user
        static int GetIndex(int arrayLength)
        {
            int index;
            bool isValid;

            do
            {
                Console.Write("Enter an index (0 to {0}): ", arrayLength - 1);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out index) && index >= 0 && index < arrayLength;

                if (!isValid)
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }

            } while (!isValid);

            return index;
        }

        // Function to display the element at the specified index
        static void DisplayAtIndex<T>(T[] array, int index)
        {
            Console.WriteLine($"Element at index {index}: {array[index]}");
        }

        // Function to display the element at the specified index for a list
        static void DisplayAtIndex<T>(List<T> list, int index)
        {
            Console.WriteLine($"Element at index {index}: {list[index]}");
        }
    }
}
