Number Logger

This C# program prompts the user to input a number, validates the input, writes the number to a text file, reads the contents of the text file, and prints them back to the user.

Description

The program consists of one file:

Program.cs:
This file contains the Main method, serving as the entry point of the program.
It prompts the user to enter a number.
It validates the input to ensure it is a valid number.
If the input is valid, the program writes the number to a text file using the WriteToFile method.
It then reads the contents of the text file using the ReadFromFile method and prints them back to the user.
If the input is not a valid number, the program informs the user.
The console window remains open until a key is pressed.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in your preferred C# development environment (e.g., Visual Studio).
Build and run the program.

Program Execution

The program prompts the user to enter a number.
If the user enters a valid number, the program writes the number to a text file located at C:\Users\maksi\Logs\number.txt.
The program then reads the contents of the text file and prints them back to the user.
If the user enters an invalid input, the program informs the user to enter a valid number.
The console window remains open until a key is pressed.
