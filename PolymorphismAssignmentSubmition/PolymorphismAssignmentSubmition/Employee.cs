using System;

namespace PolymorphismAssignmentSubmition
{
    //Define the Employyee class inhereting from person and implementing  IQuittable interface
    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Employee quits the job");
        }
    }
}
