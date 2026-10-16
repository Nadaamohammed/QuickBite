# 🍔 QuickBite — Food Delivery Backend API

QuickBite is a modern, scalable RESTful backend service for a food delivery platform built with **ASP.NET Core**, **Entity Framework Core**, and **ASP.NET Core Identity**.

---

## 🚀 Features

- **Authentication & User Management**: ASP.NET Core Identity with support for external providers (Google, Apple), custom user profiles, dietary preferences, and multi-address management.
- **Restaurant & Menu Catalog**: Restaurants, categories, items, and customizable options (sizes, add-ons, toppings).
- **Cart & Order Processing**: Dynamic cart calculations, item customizations, and full order checkout workflows.
- **Coupons & Promotions**: Promo code validation, usage tracking, and order discount calculation.
- **Delivery & Courier Tracking**: Real-time delivery status, driver assignment, and verification codes.
- **Reviews & Ratings**: Order-linked restaurant reviews and ratings.
- **In-App Notifications**: Push and in-app system/order notifications.

---
## 🛠️ Tech Stack

- **Framework**: .NET 10 
- **Architecture**: Clean Architecture 
- **ORM**: Entity Framework Core
- **Database**: SQL Server 
- **Security**: ASP.NET Core Identity & JWT (JSON Web Tokens)
- **Documentation**: Swagger

---

## 📂 Project Architecture
QuickBite/ 
├── QuickBite.Domain/ # Entities, Enums, Interfaces │
└── Entities/ │ ├── User.cs # Inherits from IdentityUser │ ├── Address.cs │ ├── Restaurant.cs │ ├── MenuItem.cs │ ├── CustomizationOption.cs │ ├── Cart.cs ├─Order.cs │ ├── Delivery.cs │ └── ...
├── QuickBite.Infrastructure/ # Persistence, Migrations, DB Context │ └── Data/ │ └── QuickBiteDbContext.cs ├──
QuickBite.Application/ # Services, DTOs, CQRS/Handlers, Validators
└── QuickBite.API/ # Controllers, Middlewares, Program.cs

---

## ⚙️ Getting Started

### Prerequisites

- [.NET SDK 10.0+](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or [Docker](https://www.docker.com/) for local DB
- ---

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/QuickBite.git
   cd QuickBite
2. **Configure Connection String Update appsettings.json in QuickBite.API**
   {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=QuickBiteDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
}
3. **Run EF Core Migrations**
   dotnet ef database update --project QuickBite.Infrastructure --startup-project QuickBite.API
4. **Run the API**
   dotnet run --project QuickBite.API
5. **Explore Swagger UI**
   https://localhost:5001/swagger
---
   
📊 **Database Schema & Key Entities**
User: Extends IdentityUser with BitePoints balance, membership tiers, and contact preferences.
Restaurant & Menu: Categorized menu items with hierarchical customizable options (e.g., Patty size, Cheeses, Add-ons).
Cart & Order: Cart with snapshot pricing into orders and order items.
Delivery: Courier assignment, tracking URL, and status workflow (Assigned -> InTransit -> Delivered).

---

<img width="4869" height="8192" alt="Class Digram" src="https://github.com/user-attachments/assets/25193c4e-595d-4bf0-90fd-4f87543a7ce3" />
