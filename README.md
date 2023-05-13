# Hadassim
# Hmo Simulation - ASP.NET Core Web API

This is a C# project developed in ASP.NET Core Web Application using the 4-layer Entity Framework method and Swagger for API documentation. The project simulates a health fund with two departments: MEMBER and COVID. 

## Prerequisites

- Visual Studio 2022
- .NET Core
- SQL Server

## Getting Started

1. Clone the repository to your local machine.
2. 
3. Open the solution file Project
 in Visual Studio.
 
3. Configure the database connection string in the appsettings.json
 file with your SQL Server details.
 
4. Open the Package Manager Console and run the following command to create the database:
   Update-Database
   
5. Build and run the project.

## Project Structure

The project follows the 4-layer Entity Framework method, which separates the application into the following layers:
*BLL
Dal
DTO
Entity

The project also uses Swagger for API documentation. You can access the Swagger UI by navigating to https://localhost:7240/swagger


## Departments

The project simulates a Hmo with two departments: MEMBER and COVID.

### MEMBER

The MEMBER department is responsible for managing the members of the Hmo. The following endpoints are available:

- GET /api/members
: Returns a list of all members.
- GET /api/members/{id}
: Returns a specific member by ID.
- POST /api/members
: Creates a new member.
-Post/api/members/{id,Covid}
:add Vaccine to specific member


### COVID

The COVID department is responsible for managing the COVID-19 Vaccines . The following endpoints are available:

- GET /api/covid-cases
: Returns a list of all Vaccines.
- GET /api/covid{id}
: Returns a specific Vaccine by pepole ID.
- POST /api/covid
: Creates a new Vaccine .

