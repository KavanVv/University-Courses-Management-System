# University Management System 🎓

A simple web-based University Management System built with ASP.NET Core MVC, Entity Framework Core, and Identity for authentication and authorization.

##  Tech Stack

- ASP.NET Core MVC (.NET 6 / 7)
- Entity Framework Core
- ASP.NET Core Identity (Role-based access)
- SQLite / SQL Server (depending on setup)
- Bootstrap 5 (for UI)

---

##  Features

- Role-based login (Admin, Faculty, Student)
- Admin:
  - Create, edit, delete, and view courses
- Viewer (Faculty/Student):
  - View courses only (read-only access)

---

## Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/KavanVv/UniversityManagement.git
cd UniversityManagement
```

### 2. Configure the Database
Use either SQLite or SQL Server. Update the connection string in appsettings.json:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=university.db"
}
```

### 3. Apply Migrations and Seed the DB
```bash
dotnet ef database update
```

If you have multiple DbContexts:
```bash
dotnet ef database update --context ApplicationDbContext
```

### 4. Run the Project
```bash
dotnet run
```
Visit: http://localhost:5000

---

## User Roles

- Register a new account: `/Identity/Account/Register`
- After registration, manually assign Admin role using DB (AspNetUserRoles table).
- Admin Role: Can manage courses
- Other users: Can only view

---

## Default Admin Account (if seeded manually)

Email: admin@university.com  
Password: Admin@123  
Role: Admin

> Note: You'll need to assign this role manually or via a seed method.

---

## 📂 Folder Structure

- Models/ — Contains Course.cs and identity models
- Controllers/ — Logic for handling requests (CoursesController)
- Views/ — Razor views for Courses and Shared layout
- Data/ — ApplicationDbContext and role seeders

---

##  Contributing

Feel free to fork and raise a pull request if you'd like to improve this system!

---

##  License

This project is licensed under the MIT License.

