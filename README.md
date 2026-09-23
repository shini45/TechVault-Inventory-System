# TechVault: Computer Parts Inventory Management System

## Overview
TechVault Inventory System is a full-stack enterprise architecture asset tracking application engineered with a **C# Windows Forms frontend client desktop application** and an **ASP.NET Core RESTful Web API backend framework**. Upgraded significantly from volatile in-memory layers, the system uses **Entity Framework Core object-relational mapping** to persistently write enterprise inventory records directly inside a local **SQL Server LocalDB database engine configuration repository**.

## Features
- **Persistent Data Management:** Complete integration with local SQL database tables architecture (`dbo.Items` and `dbo.InventoryTransactions`) ensuring absolute data longevity across application lifecycles.
- **Advanced Inventory Ledger Controls:** Implemented customized non-CRUD boundary controllers providing automated operational functions such as structural inventory intake handling (`+ Stock In`) and strict conditional dispatch constraints (`- Stock Out`).
- **Dynamic Structural Validation:** Embedded background rule checks that evaluate current product balance capacities, throwing warning exception alerts when invalid operational quantities are entered.
- **Visual Auditing Indicator Grid:** Real-time data grid tracking featuring custom low-stock background highlighting matrices (Pastel Red for critical stock <= 5, Peach/Amber for warning level stock <= 10).
- **Asynchronous Search Optimization:** Client-side query search fields that filter active directory rows instantaneously across columns.

## Technologies Used
- **C# Programming Language**
- **.NET 10.0 runtime development environment framework**
- **ASP.NET Core RESTful Web Service APIs**
- **Entity Framework Core (Migrations & DB Context Layer Drivers)**
- **SQL Server LocalDB / SSMS (SQL Server Management Studio)**
- **Windows Forms Graphical User Interface (GUI-based client)**
- **Visual Studio 2026 IDE**
- **Git / GitHub Version Control pipelines**

## Web Service API Operations
- `GET /api/Items` - Retrieves all operational inventory listings via live database queries.
- `GET /api/Items/{id}` - Extracts specific item parameters mapped to an individual unique identification index block.
- `POST /api/Items` - Initializes a new product asset configuration record directly into the disk array.
- `PUT /api/Items/{id}` - Updates explicit descriptive metadata variables associated with target hardware assets.
- `PUT /api/Items/{id}/restock` - Advanced operational gateway that coordinates unit quantity restock additions.
- `PUT /api/Items/{id}/stock-out` - Advanced operational gateway that handles strict unit quantity reduction transactions.
- `GET /api/Items/transactions` - Tracking route endpoint that serves audit logs context data packages.
- `DELETE /api/Items/{id}` - Permanently drops target product references from the live production infrastructure clusters file system layout logs.

## Application Architecture Overview
TechVault acts as a secured enterprise hub optimized to manage technical peripheral devices (laptops, gaming keyboards, monitors, system components). By separating the layout rendering layer (WinForms Client Interface) from the storage processing layer (ASP.NET Web API Controller Framework), the platform enforces strict structural encapsulation principles ideal for scalable environment layouts.

## Developer
**Developed by:** Vernadith C. Senin
