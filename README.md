Event Management System - C# Implementation
Description
This project is part of a group assignment for the COMP40003 Software Development and Application Modelling module at Asia Pacific Institute of Information Technology (APIIT), Sri Lanka (Partnered with Staffordshire University UK). The assignment focuses on designing and implementing an Event Management System using Object-Oriented Programming (OOP) concepts and C# Programming. The system provides an interface for managing events, participants, organizers, and bookings.

Learning Outcomes
Upon completing this assignment, we have achieved the following learning outcomes:

OOP Implementation

Applied Object-Oriented Programming (OOP) principles such as Encapsulation, Inheritance, and Polymorphism in developing a real-world application.
Database Integration

Integrated a SQL database for persistent data storage.
Windows Forms Development

Built a Windows Forms application for the Event Management System interface.
Application Modelling and Testing

Developed and tested functional modules for event, participant, and booking management.
Project Structure
CB013248
This folder contains the primary source code, resources, and project configurations.

CB013248_Windows_Forms:

Contains all the Windows Forms application files.
CB013248_Windows_Forms.sln: Visual Studio solution file that ties together the project components.
.vs:

Contains Visual Studio configuration files (for local IDE settings, caches, etc.).
Icons and Background Images:

Create Event.png: Icon used for creating new events.
Manage Bookings.png: Icon for managing bookings.
Manage Events.png: Icon for managing events.
Manage Organizers.png: Icon for managing event organizers.
Manage Participants.png: Icon for managing participants.
Registered Events.png: Icon for viewing registered events.
Remove Event.png: Icon for removing an event.
Remove Participants.png: Icon for removing participants.
View Registered Participants.png: Icon for viewing registered participants.
SQL File:

eventmanagementdb.sql: SQL script file used to create the database and tables required for the application.
Technologies Used
Programming Language: C#
Database: Microsoft SQL Server
IDE: Visual Studio
Database Management: SQL Server Management Studio (SSMS)
Installation Instructions
To set up and test the Event Management System locally, follow these steps:

Clone the Repository:

bash
Copy code
git clone https://github.com/thieveshkar/SDAM-2.git  
Setup the Database:

Open SQL Server Management Studio (SSMS).
Open the SQL File located at SQL File/eventmanagementdb.sql.
Execute the script to create and populate the database tables.
Open the Project in Visual Studio:

Open the CB013248_Windows_Forms folder as a project in Visual Studio.
Open the solution file CB013248_Windows_Forms.sln.
Build and Run the Application:

Press F5 to build and run the application.
The Windows Forms application will launch with the main interface for event management.
Login Credentials:

Admin Login: admin@example.com / admin123
Participant Login: participant@example.com / password123
