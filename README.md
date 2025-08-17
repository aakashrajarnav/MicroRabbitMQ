# MicroRabbitMQ 🐇📬

A lightweight microservices architecture built using ASP.NET Core and RabbitMQ for asynchronous communication between services. This project demonstrates how to decouple services using an event-driven approach, making the system scalable, maintainable, and resilient.

---

## 📦 Overview

MicroRabbitMQ is a sample implementation of microservices architecture using **RabbitMQ** as the message broker. It showcases how to use **Domain-Driven Design (DDD)**, **Command Query Responsibility Segregation (CQRS)**, and **Event Sourcing** principles in a .NET ecosystem.

The solution is split into multiple services:
- **MicroRabbit.Domain** – Contains core domain models and interfaces.
- **MicroRabbit.Infrastructure** – Implements data access and messaging logic.
- **MicroRabbit.Transfer** – A service responsible for handling money transfers.
- **MicroRabbit.Banking** – A service responsible for banking operations.
- **MicroRabbit.MVC** – ASP.NET Core MVC frontend to interact with the system.

---

## 🛠 Tech Stack

![Tech Stack](https://img.shields.io/badge/TechStack-.NET%208%20%7C%20RabbitMQ%20%7C%20EF%20Core%20%7C%20MVC%20%7C%20CQRS%20%7C%20DDD-blue)

- **.NET 8 / ASP.NET Core**
- **RabbitMQ** for messaging
- **Entity Framework Core** for ORM
- **MVC** for frontend
- **MediatR** for command/query handling
- **Swagger** (optional) for API documentation

---

## 🧪 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- RabbitMQ Server installed locally
- SQL Server or any compatible database

### Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/aakashrajarnav/MicroRabbitMQ.git

2. Install and run RabbitMQ locally. You can use the RabbitMQ installer for your OS.
3. Update connection strings in appsettings.json for each service.
4. Run the solution using Visual Studio or dotnet run.

 ##  📬 Message Flow
Here’s how the services communicate using RabbitMQ:
- MVC app sends a transfer request.
- Transfer service publishes an event to RabbitMQ.
- Banking service subscribes to the event and updates the account balance.

## 🤝 Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you’d like to change.

## 📄 License
This project is licensed under the MIT License.
