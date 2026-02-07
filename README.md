# 🎮 Game Library API

A RESTful Web API built with **ASP.NET Core** and **Entity Framework Core** to manage a collection of video games. This project demonstrates backend development skills including CRUD operations, database connectivity, and API documentation.

## 🚀 Technologies Used

* **C#**
* **.NET 8** (ASP.NET Core Web API)
* **Entity Framework Core** (ORM)
* **SQL Server** (LocalDB)
* **Swagger / OpenAPI** (Documentation)
* **HTML / CSS / JS** (Frontend)

## ✨ Features

* **CRUD Operations:** Create, Read, Update, and Delete game records.
* **Data Persistence:** Uses MS SQL Server to store data.
* **DTO Pattern:** (Optional: Data Transfer Objects for clean data handling).
* **Dependency Injection:** Proper service lifetime management.

## 🛠️ Getting Started

Follow these steps to run the project locally.

### Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.
* SQL Server (LocalDB or Express) installed.
* Visual Studio 2022 or VS Code.

### Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/Niveron228/Game-Library.git](https://github.com/Niveron228/Game-Library.git)
    cd Game-Library
    ```

2.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```

3.  **Update the Database (Apply Migrations):**
    *Make sure your ConnectionString in `appsettings.json` is correct.*
    ```bash
    dotnet ef database update
    ```

4.  **Run the application:**
    ```bash
    dotnet run
    ```

5.  **Open Swagger:**
    Navigate to `http://localhost:5000/swagger` (or the port shown in your terminal) to test the API endpoints.

## 📡 API Endpoints

| Method | Endpoint      | Description           |
| :---   | :---          | :---                  |
| `GET`  | `/api/games`  | Get all games         |
| `GET`  | `/api/games/{id}` | Get a game by ID  |
| `POST` | `/api/games`  | Add a new game        |
| `PUT`  | `/api/games/{id}` | Update an existing game |
| `DELETE` | `/api/games/{id}` | Delete a game     |

##📸 Screenshots
<img width="902" height="791" alt="Знімок екрана 2026-02-07 131818" src="https://github.com/user-attachments/assets/9ade5c1d-1377-43a7-92c5-f9d4d920e52d" />
<img width="904" height="1037" alt="Знімок екрана 2026-02-07 131823" src="https://github.com/user-attachments/assets/976d9f22-a9bb-49e3-b670-52494fe277f7" />


## 👤 Author

**Artem Haliv**
* Student at Vistula University
* Aspiring C# .NET / Java Developer & QA Engineer

---
*Created as part of a .NET portfolio project.*
