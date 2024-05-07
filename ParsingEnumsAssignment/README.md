Parsing Enums Assignment

This C# program demonstrates how to parse user input into an enum representing the days of the week.

Description

The program consists of one file:

Program.cs:
This file defines an enum named DaysOfTheWeek, which represents the days of the week.
It contains the Main method, serving as the entry point of the program.
Inside the Main method, there is a while loop that continues until the user enters a valid day of the week.
Within the loop, the user is prompted to enter the current day of the week.
The program attempts to parse the user input into the DaysOfTheWeek enum using Enum.Parse.
If the parsing is successful, the program prints a message indicating the day of the week to the console.
If the user enters an invalid input (not a valid day of the week), an ArgumentException is caught, and the user is prompted to enter a valid day of the week.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in your preferred C# development environment (e.g., Visual Studio).
Build and run the program.

Program Execution

The program prompts the user to enter the current day of the week.
If the user enters a valid day of the week, the program prints a message indicating the day to the console (e.g., "Have a nice Monday").
If the user enters an invalid input (not a valid day of the week), the program informs the user to enter an actual day of the week and prompts them again.
The loop continues until the user enters a valid input.
The console window remains open until a key is pressed.
