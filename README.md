# CarInsurance


## Overview

CarInsurance is an ASP.NET Core MVC web application designed to calculate auto insurance quotes based on a variety of user inputs such as age, car details, driving history, and insurance coverage type. The application leverages Entity Framework Core for data access, and it includes functionality to manage users and their quotes, as well as an administrator view to oversee all issued quotes.
Features

    ASP.NET Core MVC structure with Model-View-Controller pattern.
    Entity Framework Core for database management and CRUD operations.
    Insurance Quote Calculation based on:
        User's age, car year, make and model.
        Number of speeding tickets and DUI history.
        Choice of coverage type (liability vs. full coverage).
    Administrative Panel to view all quotes issued along with user information.

Quote Calculation Logic

The application calculates an insurance quote using the following rules:

    Base Rate: $50/month for all users.
    Age Adjustments:
        Add $100 for users aged 18 or younger.
        Add $50 for users aged between 19 and 25.
        Add $25 for users aged 26 or older.
    Car Year Adjustments:
        Add $25 if the car's year is before 2000.
        Add $25 if the car's year is after 2015.
    Car Make Adjustments:
        Add $25 if the car make is Porsche.
        Add an additional $25 if the model is a Porsche 911 Carrera (total $50 for this car).
    Speeding Tickets: Add $10 for each speeding ticket.
    DUI: If the user has a DUI, add 25% to the total quote.
    Coverage Type: If the user opts for full coverage, add 50% to the total quote.

Technologies Used

    ASP.NET Core MVC: Backend framework for building the web app.
    Entity Framework Core: ORM for interacting with the database.
    SQL Server: For database management.
    HTML, CSS, Bootstrap: For frontend design and layout.
