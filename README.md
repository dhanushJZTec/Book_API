# 📚 Books API

A simple ASP.NET Core Web API that performs full CRUD operations for managing books using an in-memory collection.

---

## 🚀 Features

- Get all books
- Get book by ID
- Add a new book
- Update existing book
- Delete a book
- Validation using Data Annotations
- Swagger integration
- Postman collection included

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- C#
- Swagger
- Postman
- LINQ
- In-memory List<Book>

---

## 📂 Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/books | Get all books |
| GET | /api/books/{id} | Get book by ID |
| POST | /api/books | Create a new book |
| PUT | /api/books/{id} | Update a book |
| DELETE | /api/books/{id} | Delete a book |

---

## ▶️ Run the Project

1. Open solution in Visual Studio
2. Press `Ctrl + F5`
3. Swagger opens automatically

Example:

```text
https://localhost:7271/swagger

🧪 Postman Testing

The project includes:

Books_API.postman_collection.json

Import it into Postman to test all CRUD endpoints.

✅ Validation

The API validates:

Title is required
Author is required
👨‍💻 Author

Dhanush