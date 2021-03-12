# Dr. Sillystringz's Factory

#### _Track Engineers and the Machines they maintain, 03/12/2021_

#### By _**Tristen Everett**_

## Description

This project was an attempt at showing the skills I learned to program in C#. In this project I built a ASP.NET MVC webapp that allows the user to add engineers and machines to the database. The user will then be able to create relationships between engineers and machines from either side to document which engineers are qualified to work on which machines. The user will do this by navigating between multiple pages that allow viewing, creation, modification, and deletion of the entries in the database. This project was built to meet the needs of the user stories listed below.

### User Stories

* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed.
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.

## Setup/Installation Requirements

1. Clone this Repo
2. Run `dotnet ef database update` from within /Factory to create the database
3. You may need to update the file /Factory/appsettings.json to match the userID and password for the computer your using
4. Run `dotnet restore` from within /Factory file location
5. Run `dotnet build` from within /Factory file location
6. Run `dotnet run` from within /Factory file location
7. Using your preferred web browser navigate to http://localhost:5000/

## Technologies Used

* C#
* ASP.NET Core
* Entity Framework Core
* MYSQL
* Razor Pages

### License

This software is licensed under the MIT license

Copyright (c) 2021 **_Tristen Everett_**