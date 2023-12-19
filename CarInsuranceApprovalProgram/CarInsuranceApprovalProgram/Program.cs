using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car insurance Approval Program\n");

            //Asking questions
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you evere had a DUi? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            //Checking qualification rules
            bool qualifiesForInsurance = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

            //printing results
            Console.WriteLine("\nQualifies for car insurance:" + qualifiesForInsurance);

            Console.ReadLine();
        }
    }
}
