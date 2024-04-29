using System;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Create a new Student object
                var student = new Student
                {
                    Name = "John Doe",
                    EnrollmentDate = DateTime.Now
                };

                // Add the Student object to the Students DbSet
                context.Students.Add(student);

                // Save the changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }
        }
    }
}