Constructor Assignment

This C# console application demonstrates the usage of constructors with different parameter types (float and string) and chaining constructors together.

Description

The program consists of two files:

Program.cs: This file contains the Main method, which is the entry point of the program. It prompts the user to enter their name or favorite number. It then checks if the input can be parsed as a float. If it can, it creates an instance of the Chain class using the float value. If not, it creates an instance using the string value.
Chain.cs: This file defines the Chain class, which contains two properties (Name and Num) and three constructors:
A constructor that takes a float and a string as parameters.
A constructor that takes a float as a parameter. This constructor chains to the first constructor by providing a default name value.
A constructor that takes a string as a parameter. This constructor chains to the first constructor by providing a default float value.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in Visual Studio or your preferred C# development environment.
Build and run the program.
Enter your name or favorite number as prompted.

Note

This program serves as a basic demonstration of constructor overloading and constructor chaining in C#. You can modify the program to add additional functionality or customize it according to your requirements.
