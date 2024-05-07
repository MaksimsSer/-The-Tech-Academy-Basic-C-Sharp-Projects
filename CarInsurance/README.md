Car Insurance Application

This ASP.NET MVC application calculates insurance quotes for customers based on various factors such as age, car details, driving history, and coverage type.

Description

The application consists of several files and functionalities:

InsureeController.cs: This file contains the controller logic for handling insurance-related actions such as calculating quotes, displaying insuree details, creating, editing, and deleting insuree records.
MathMethods.cs: This file contains the logic for calculating insurance quotes based on the provided insuree data.
Create.cshtml: This file represents the view for creating a new insuree record. It contains form fields for entering insuree details and displays the calculated insurance quote.
Admin.cshtml: This file represents the view for displaying all insuree records with their corresponding quotes in a tabular format.
HomeController.cs: This file contains the controller logic for handling the home, about, and contact pages of the application.
Insurance.mdf: This is the SQL Server database file containing the Insuree table schema and data.

Usage

To run the application, follow these steps:

Clone or download this repository to your local machine.
Open the solution in Visual Studio.
Attach the Insurance.mdf database file to your local SQL Server instance. You can do this by:
In Visual Studio, open the "SQL Server Object Explorer" window.
Right-click on "Data Connections" and choose "Add Connection..."
In the "Add Connection" dialog, select "Microsoft SQL Server" as the data source and provide your server name and authentication details.
Click "Browse" and navigate to the location of the Insurance.mdf file.
Once connected, you should see the Insurance.mdf database listed under your server in SQL Server Object Explorer.
Build and run the application.
Navigate to the Insuree section to create, view, edit, or delete insuree records.
Navigate to the Admin section to view all insuree records with their quotes.

Note

This application serves as a basic demonstration of building an insurance quote calculator using ASP.NET MVC. You can further enhance it by adding authentication, validation, additional features, or integrating it with a more robust database solution.
