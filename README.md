# Customer Data Blazor App

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Blazor](https://img.shields.io/badge/framework-Blazor-orange.svg)
![Status](https://img.shields.io/badge/status-active-brightgreen.svg)

## Description

**Customer Data Blazor App** is a web application built with Blazor for managing and displaying customer data. It enables easy creation, viewing, and deletion of customer records, with data stored securely on a PostgreSQL database.

## Key Features

- **CRUD operations** for customer records (create, read, and delete)
- **Data visualization** with search and filtering capabilities
- **Responsive Blazor-based interface**
- **Secure data handling** and protection from unauthorized access
- **REST API support** for external integration

## Structure

The project is divided into two main parts:

- **Server Side (API)** - Located in the `api` folder, responsible for managing data operations and serving the REST API.
- **Client Side (App)** - Located in the `app` folder, containing the Blazor front-end application for interacting with the data.

Each part needs to be started separately for the application to function correctly.

## Installation

To run the project locally, follow these steps:

1. Clone the repository:

    ```bash
    git clone https://github.com/AntonyBl4ck/CustomerDataBlazorApp.git
    ```

2. Navigate to the project directory:

    ```bash
    cd CustomerDataBlazorApp
    ```

### Prerequisites

- **PostgreSQL** - Ensure that PostgreSQL is installed and running. Create a database and update the connection string in the API configuration file accordingly.

### Running the API (Server-Side)

1. Go to the API directory:

    ```bash
    cd api
    ```

2. Build and start the API server:

    ```bash
    dotnet build
    dotnet run
    ```

### Running the App (Client-Side)

1. Open a new terminal and navigate to the App directory:

    ```bash
    cd app
    ```

2. Build and start the client application:

    ```bash
    dotnet build
    dotnet run
    ```

## Technology Stack

- **Blazor** — for building the web interface
- **ASP.NET Core** — for server-side API
- **Entity Framework Core** — for data management
- **PostgreSQL** — for storing customer data

## API Endpoints

The API allows managing customer data. Available endpoints:

- `GET /api/customers` — retrieve all customers
- `POST /api/customers` — add a new customer
- `DELETE /api/customers/{id}` — delete a customer

## Session Management

This code includes a basic session handling demonstration; however, the session data is not stored persistently, as this is a sample method. 

For a production environment, consider using **JSON Web Tokens (JWT)** for secure session management. JWT can be implemented using frameworks like ASP.NET Identity or libraries such as `System.IdentityModel.Tokens.Jwt`. JWT tokens would be issued upon successful login, stored securely on the client-side (e.g., in HTTP-only cookies or local storage with caution), and then sent with each request to authenticate and authorize users. This approach provides a scalable and secure method for managing user sessions in a real-world application.
