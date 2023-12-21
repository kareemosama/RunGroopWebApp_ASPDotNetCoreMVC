# RunGroop Web App - ASP.NET Core MVC

![Main Page](https://github.com/kareemosama/RunGroopWebApp_ASPDotNetCoreMVC/blob/main/public/assets/GitImages/MainPage.png)
![ProductListWithFilter](https://github.com/kareemosama/RunGroopWebApp_ASPDotNetCoreMVC/blob/main/public/assets/GitImages/ProductListWithFilter.png)
![ProductDetails](https://github.com/kareemosama/RunGroopWebApp_ASPDotNetCoreMVC/blob/main/public/assets/GitImages/ProductDetails.png)
![Register](https://github.com/kareemosama/RunGroopWebApp_ASPDotNetCoreMVC/blob/main/public/assets/GitImages/Register.png)

## Table of Contents

- [About](#about)
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Project Link](#project-link)
- [References](#references)

## About

RunGroop Web App is a feature-rich web application built using ASP.NET Core MVC. It provides users with a seamless experience for managing running groups, exploring events, and user registration. This project serves as a solid foundation for creating dynamic web applications tailored to unique requirements.

## Features

- **Group Management:** Efficiently manage running groups with features for creating, updating, and deleting groups.
- **Event Exploration:** Explore a variety of running events, view details, and register for participation.
- **User Registration:** Secure user accounts with a robust authentication system for member registration.
- **Intuitive UI:** A clean and intuitive user interface for a seamless experience.

## Technologies

The project is primarily built using the following technologies:

- **ASP.NET Core MVC:** The server-side framework for building the web application.
- **C#:** The primary language for server-side logic.
- **Entity Framework Core:** A powerful ORM for interacting with the database.
  1. Code-First model for database interaction.
  2. Migrations for database schema updates.
- **MVC (Model-View-Controller):** The architectural pattern for organizing and managing the application's structure.
- **Repository Design Pattern:** A design pattern used to separate the logic that retrieves data from the underlying storage.
- **ASP.NET Core Identity:** A membership system that adds login functionality and user management to the application.
  1. Authentication and Authorization: Secure user authentication and authorization features.
  2. Role Management: Implement role-based access control for users.

## Getting Started

To get started with RunGroop Web App, follow the [Getting Started](#getting-started) section in this README to set up your development environment and install the necessary dependencies.

### Prerequisites

Before you begin working with RunGroop Web App, ensure that you have the following software installed on your machine:

- [.NET Core SDK](https://dotnet.microsoft.com/download): The framework required to build and run the application.
- [Visual Studio](https://visualstudio.microsoft.com/): A popular integrated development environment (IDE) for .NET applications.

### Installation

Follow these steps to set up and run RunGroop Web App locally:

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/kareemosama/RunGroopWebApp_ASPDotNetCoreMVC.git
   cd RunGroopWebApp_ASPDotNetCoreMVC

   ```

2. **Restore Packages::**

   ```bash
   dotnet restore
   ```

3. **Update Database:**

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the Application:**

   ```bash
   dotnet run
   ```

# Refrence

- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0):Official documentation for ASP.NET Core.
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/):Official documentation for Entity Framework Core.
- [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0&tabs=visual-studio):Official documentation for ASP.NET Core Identity.
