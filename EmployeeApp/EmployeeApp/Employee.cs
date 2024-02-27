using System;

namespace EmployeeApp
{
    //Define the Employee class
    public class Employee
    {
        //Properies of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor to initialize Employee Object
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //Overloading the "==" operator to compare Employee objects by their ID property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //Check if both objects are null or if their reference is the same
            if (ReferenceEquals(emp1, emp2))
                return true;
            //Check if one of the objects is null
            if (emp1 is null || emp2 is null)
                return false;
            //Compare the Id property of both objects
            return emp1.Id == emp2.Id;
        }

        //Overloading the "!=" operator to complement the overload "==" operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            //Use the inverse of the overloaded "==" operator
            return !(emp1 == emp2);
        }
    }

}
