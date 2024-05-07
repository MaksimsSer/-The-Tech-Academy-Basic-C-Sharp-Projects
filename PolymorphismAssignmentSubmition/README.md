Polymorphism Assignment Submission

This C# program demonstrates the usage of polymorphism with interfaces in object-oriented programming.

Description

The program consists of four files:

Program.cs:
This file contains the Main method, serving as the entry point of the program.
It instantiates an Employee object, sets its properties, and calls the SayName method to print the employee's name.
It utilizes polymorphism to create an object of type IQuittable and calls the Quit method on it.
IQuittable.cs:
This file defines an interface named IQuittable with a method Quit.
Employee.cs:
This file defines the Employee class, which inherits from the Person class and implements the IQuittable interface.
It provides an implementation for the Quit method specified in the IQuittable interface.
Person.cs:
This file defines the Person class with properties FirstName and LastName.
It contains a method SayName to print the person's name to the console.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in your preferred C# development environment (e.g., Visual Studio).
Build and run the program.

Program Execution

The program instantiates an Employee object and sets its properties (FirstName and LastName).
The SayName method is called to print the employee's name to the console.
Polymorphism is demonstrated by creating an object of type IQuittable and calling the Quit method on it.
The Quit method prints a message indicating that the employee quits the job to the console.
The console window remains open until a key is pressed.
