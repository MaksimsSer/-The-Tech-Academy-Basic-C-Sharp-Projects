using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();

            // Validate if the input is a valid number
            if (int.TryParse(input, out int number))
            {
                // Write the number to a text file
                WriteToFile(number);

                // Read the text file and print its contents back to the user
                string fileContents = ReadFromFile();
                Console.WriteLine("Contents of the text file:");
                Console.WriteLine(fileContents);
            }
            else
            {
                // Inform the user if the input is not a valid number
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadLine();
        }

        static void WriteToFile(int number)
        {

            // Write the number to the text file
            using (StreamWriter writer = new StreamWriter(@"C:\Users\maksi\Logs\number.txt"))
            {
                writer.WriteLine(number);
            }
        }

        static string ReadFromFile()
        {

            // Read the contents of the text file
            string fileContents = File.ReadAllText(@"C:\Users\maksi\Logs\number.txt");

            return fileContents;
        }
       
    }
    
}
