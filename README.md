# Network Components Management Application

This project is a web application designed for managing network components, based on the provided schema. The application allows users to manage different network components, their types, and locations efficiently.
<p align="center">
  <img src="https://github.com/user-attachments/assets/6bec300d-9193-4872-a682-e2dddec14f65" alt="nc" />
</p>

## Features
- Manage various network components such as servers, devices, and wiring.
- Classify components by type and location.
- Associate components with geographic locations and facilities.

## Technologies Used
- **Backend:** C# (ASP.NET Core MVC)
- **Frontend:** Razor Pages (part of the MVC pattern)
- **Database:** Entity Framework Core

## Architecture
The application follows the **Model-View-Controller (MVC)** pattern:
- **Model:** Represents the network component entities and their relationships as defined in the schema.
- **View:** Handles the user interface and displays data to the user.
- **Controller:** Manages user input, processes it, and updates the model or view accordingly.
