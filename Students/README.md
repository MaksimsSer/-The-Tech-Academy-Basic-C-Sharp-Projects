EF Code-First Demo

This C# program demonstrates the Entity Framework Core Code-First approach for creating a database table named Students and adding a student record.

Description

The program consists of three files:

SchoolContext.cs:
This file defines the SchoolContext class, which inherits from DbContext.
It contains a DbSet property named Students for accessing the Students table in the database.
It overrides the OnConfiguring method to specify the database connection string.
Student.cs:
This file defines the Student class, representing the entity structure of a student.
It contains properties representing the student's ID, name, and enrollment date.
Program.cs:
This file contains the Main method, serving as the entry point of the program.
Inside the Main method, it creates a new SchoolContext instance.
It creates a new Student object with some sample data.
It adds the Student object to the Students DbSet.
It saves the changes to the database using the SaveChanges method.
Finally, it prints a confirmation message to the console.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in your preferred C# development environment (e.g., Visual Studio).
Build and run the program.

Program Execution

The program creates a new Student object with sample data.
It adds the Student object to the Students table in the database.
It saves the changes to the database.
It prints a confirmation message to the console indicating that the student was added successfully.
