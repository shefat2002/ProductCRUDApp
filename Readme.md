
# 🛒 ProductCraft – ASP.NET Core MVC CRUD App

**ProductCraft** is a simple and clean ASP.NET Core MVC application for managing products with full CRUD operations using the Repository and Service patterns.

---

## 🚀 Features

- Create, Read, Update, and Delete products
- Repository Pattern for data abstraction
- Service Layer for business logic
- Clean folder structure
- Entity: `Product` with `Id`, `Name`, `Price`, `Description`, `Stock`

---

## 🧱 Tech Stack

- ASP.NET Core MVC (.NET 9)
- Entity Framework Core
- MSSQL Server (LocalDB)
- Bootstrap for UI styling
- Razor Views

---

## 📦 Product Model

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Stock { get; set; }
}
```

---

## 🧰 Project Structure

```
ProductCRUDApp/
│
├── Controllers/
│   ├── HomeController.cs
│   └── ProductController.cs
├── Models/
│   └── Product.cs
├── Data/
│   └── AppDbContext.cs
├── Repositories/
│   ├── IGenericRepository.cs
│   ├── GenericRepository.cs
│   ├── IProductRepository.cs
│   └── ProductRepository.cs
├── Services/
│   ├── IProductService.cs
│   └── ProductService.cs
├── Views/
│   └── Product/ (Razor Views)
├── wwwroot/
│   └── CSS/JS/Bootstrap
├── appsettings.json
└── Program.cs
```

---

## ⚙️ Setup Instructions

1. **Clone the repository:**

```bash
git clone https://github.com/shefat2002/ProductCRUDApp.git
cd ProductCraft
```

2. **Update DB connection string in `appsettings.json`:**

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ProductCRUD;Trusted_Connection=True;"
}
```

3. **Apply Migrations:**

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. **Run the App:**

```bash
dotnet run
```

Open in browser: [https://localhost:5001](https://localhost:5001)

---

## 📸 Screenshots

*(Add screenshots of your Product list, Create/Edit/Delete views here)*

---

## 🙌 Credits

Made with 💻 by [Shefat Al Mahmud](https://github.com/shefat2002/)

---

## 📄 License

This project is licensed under the MIT License.
