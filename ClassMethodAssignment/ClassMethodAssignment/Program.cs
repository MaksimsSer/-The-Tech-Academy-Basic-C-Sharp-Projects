using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int magicNumber = Convert.ToInt32(Console.ReadLine());
            int healedHitpoints = MathMethods.Heal(magicNumber);
            Console.WriteLine("Healed Hitpoints: " + healedHitpoints);
            Console.ReadLine();

            Console.WriteLine("Input a phrase:");
            string input = Console.ReadLine();
            int count = CountLetterI(input);
            Console.WriteLine("Count of 'I's: " + count);
            Console.WriteLine("Doubled count of 'I's: " + (count * 2));
            Console.ReadLine();

            Console.WriteLine("Input another phrase: ");
            string input2 = Console.ReadLine();
            int phraseLength = input2.Length;
            Console.WriteLine("This phrase is " + phraseLength + " characters long");
            Console.ReadLine();

            Console.WriteLine("Input another phrase:");
            string input3 = Console.ReadLine();
            int iCount = CountLetterI(input3);
            Console.WriteLine("This phrase has " + iCount + " 'i's in it.");
            Console.ReadLine();
        }

        static int CountLetterI(string input)
        {
            // Count occurrences of 'I' or 'i'
            int count = 0;
            foreach (char c in input)
            {
                if (c == 'I' || c == 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}