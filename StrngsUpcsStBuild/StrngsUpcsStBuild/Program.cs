using System;
using System.Text;

namespace StringOperationsApp
{
    class Program
    {
        static void Main()
        {
            // Task 1: Concatenate three strings
            string str1 = "Hello, ";
            string str2 = "world!";
            string str3 = " How are you?";
            string concatenatedString = str1 + str2 + str3;
            Console.WriteLine("Concatenated String: " + concatenatedString);

            // Task 2: Convert a string to uppercase
            string lowercaseString = "convert this to uppercase";
            string uppercaseString = lowercaseString.ToUpper();
            Console.WriteLine("Uppercase String: " + uppercaseString);

            // Task 3: Create a StringBuilder and build a paragraph of text
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("This is the second sentence. ");
            paragraph.Append("And this is the third sentence.");
            Console.WriteLine("Built Paragraph: " + paragraph);

            Console.ReadLine();
        }
    }
}