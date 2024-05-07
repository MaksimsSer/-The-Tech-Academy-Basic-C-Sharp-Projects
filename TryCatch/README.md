Try-Catch Example

This C# program demonstrates the use of try-catch blocks to handle exceptions when receiving and processing user input for age calculation.

Description

The program consists of one file:

Program.cs:
This file contains the Main method, serving as the entry point of the program.
Inside the Main method, it utilizes a try-catch block to handle potential exceptions that may occur during the execution.
It prompts the user to input their age and attempts to parse the input as an integer.
If the age is negative or zero, it throws an ArgumentException with a custom error message.
If the input is not a valid integer, it catches a FormatException and displays an error message.
If any other exception occurs, it catches it as a general Exception and displays a generic error message.
After handling exceptions, it calculates the birth year based on the entered age and displays it to the user.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in your preferred C# development environment (e.g., Visual Studio).
Build and run the program.

Program Execution

The program prompts the user to input their age.
It attempts to parse the input as an integer and handles potential exceptions using try-catch blocks.
If the age is negative or zero, it displays a custom error message.
If the input is not a valid integer, it displays an error message for invalid input.
If any other exception occurs, it displays a generic error message.
After handling exceptions, it calculates the birth year based on the entered age and displays it to the user.
The console window remains open until a key is pressed.
