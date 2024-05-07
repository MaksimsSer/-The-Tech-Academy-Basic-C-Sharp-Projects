Package Express

This C# program calculates the estimated total cost for shipping a package based on its weight and dimensions.

Description

The program consists of one file:

Program.cs:
This file contains the Main method, serving as the entry point of the program.
It displays a welcome message and prompts the user to enter the package weight, width, height, and length.
It checks if the package weight exceeds the maximum weight limit of 50 pounds. If it does, the program displays a message indicating that the package is too heavy to be shipped and terminates.
It calculates the sum of the package dimensions 
(width, height, and length) and checks if the total exceeds the maximum combined dimension limit of 50 inches. 
If it does, the program displays a message indicating that the package is too big to be shipped and terminates.
If the package weight and dimensions are within acceptable limits, the program calculates the shipping cost using a formula based on the product of weight, width, height, and length, and
displays the estimated total cost to the user.
The console window remains open until a key is pressed.

Usage

To run the program, follow these steps:

Clone or download this repository to your local machine.
Open the solution in your preferred C# development environment (e.g., Visual Studio).
Build and run the program.

Program Execution

The program displays a welcome message and prompts the user to enter the package weight, width, height, and length.
If the package weight exceeds 50 pounds or the combined dimensions exceed 50 inches, the program displays an appropriate message and terminates.
If the package weight and dimensions are within acceptable limits, the program calculates the estimated total cost for shipping the package based on the provided inputs and displays it to the user.
The console window remains open until a key is pressed.
