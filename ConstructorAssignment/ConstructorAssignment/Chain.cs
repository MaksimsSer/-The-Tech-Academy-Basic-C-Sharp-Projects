using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Chain
    {
        string Name { get; set; }
        float Num { get; set; }

        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }
        //Constructor if one parameter, a float, is provided
        public Chain(float num1) : this(num1, "Maksimus")
        {
            Console.WriteLine(num1 + "and your default name is " + Name);
        }
        //Constructor if one parameter, a string, is provided
        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and your default favorite number is " + Num); 
        }

    }
}
