# RESTful API Learning Project

A hands-on educational project for learning RESTful API development with ASP.NET MVC. Features interactive web interface for testing API endpoints and progressive exercises for students.

## 🎯 Overview

This project provides a complete learning environment for understanding RESTful API concepts through practical implementation. Students work with a product inventory system that demonstrates all four CRUD operations (Create, Read, Update, Delete) with proper HTTP methods and status codes.

## 🌟 Features

- **Interactive Web Interface** - Swagger-like testing interface for all endpoints
- **4 Complete Demo Examples** - Working implementations for reference
- **16 Progressive Exercises** - From beginner to advanced challenges
- **Real-time Testing** - Immediate feedback for API calls
- **In-memory Data Storage** - No database setup required
- **Proper HTTP Methods** - GET, POST, PUT, DELETE with correct status codes
- **Error Handling** - Comprehensive error responses and validation

## 📁 Project Structure

```
RestfulAPI/
├── controller.cs              # Main controller with demos and exercises
├── model.cs                   # Product and Customer data models
├── view.cshtml               # Interactive testing interface
└── README.md                 # This file
```

## 🚀 Getting Started

### For Teachers

1. Use `controller.cs` for demonstrations (includes completed solutions)
3. Open `view.cshtml` in DotNetFiddle for interactive testing

### For Students

2. Study the 4 demo methods (fully implemented)
3. Implement the 16 exercise methods
4. Test your solutions using the web interface

### DotNetFiddle Setup

1. Go to [dotnetfiddle.net](https://dotnetfiddle.net)
2. Create new MVC project
3. Copy the controller, model, and view files
4. Run and test your API endpoints

## 📚 Learning Path

### Demo Methods (Pre-built Examples)
- `GetAllProducts()` - Retrieve all products
- `AddProduct()` - Create new product
- `UpdateProduct()` - Modify existing product  
- `DeleteProduct()` - Remove product

### Student Exercises

#### GET Endpoints (4 exercises)
- **Easy**: Get product by ID
- **Easy**: Get products by category
- **Medium**: Search products with filters
- **Challenge**: Get products in price range

#### POST Endpoints (4 exercises)
- **Easy**: Add product with duplicate name validation
- **Easy**: Add customer (different entity)
- **Medium**: Add product with required field validation
- **Challenge**: Add product with price range validation

#### PUT Endpoints (4 exercises)
- **Easy**: Update product name only
- **Easy**: Update product price only
- **Medium**: Update product with full validation
- **Challenge**: Update product with business rules

#### DELETE Endpoints (4 exercises)
- **Easy**: Delete product by name
- **Easy**: Delete customer by ID
- **Medium**: Delete with existence checks
- **Challenge**: Delete with business rule validation

## 🛠️ Technical Details

### Models
```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }
}
```

### HTTP Methods Used
- **GET** - Retrieve data
- **POST** - Create new resources
- **PUT** - Update existing resources
- **DELETE** - Remove resources

### Status Codes Covered
- `200 OK` - Successful GET/PUT/DELETE
- `201 Created` - Successful POST
- `400 Bad Request` - Validation errors
- `404 Not Found` - Resource not found
- `409 Conflict` - Business rule violations
- `500 Internal Server Error` - Server errors

## 🎓 Learning Objectives

By completing this project, students will learn:

- RESTful API design principles
- HTTP methods and status codes
- JSON request/response handling
- Data validation techniques
- Error handling best practices
- CRUD operations implementation
- Business rule enforcement
- API testing methodologies

## 🧪 Testing

The interactive web interface provides:
- **Form inputs** for all parameters
- **Execute buttons** for each endpoint
- **Real-time responses** with syntax highlighting
- **Error display** with detailed messages
- **Bootstrap styling** for professional appearance

## 📖 API Documentation

### Base URL
```
/Home/[MethodName]
```

### Example Requests

**Get All Products**
```http
GET /Home/GetAllProducts
```

**Add New Product**
```http
POST /Home/AddProduct
Content-Type: application/json

{
  "name": "iPhone 15",
  "price": 999.99,
  "category": "Electronics",
  "stock": 10,
  "description": "Latest iPhone model"
}
```

**Update Product**
```http
PUT /Home/UpdateProduct?id=1
Content-Type: application/json

{
  "name": "iPhone 15 Pro",
  "price": 1099.99,
  "category": "Electronics",
  "stock": 5,
  "description": "Latest iPhone Pro model"
}
```

**Delete Product**
```http
DELETE /Home/DeleteProduct?id=1
```

## ⚠️ Platform Notes

This project is optimized for **DotNetFiddle**, which has some limitations:
- Static variables may not persist between requests

## 🤝 Contributing

This is an educational project. Feel free to:
- Add more exercise variations
- Improve the web interface
- Add additional validation examples
- Create video tutorials
- Submit bug fixes

## 📝 License

This project is created for educational purposes. Feel free to use and modify for teaching RESTful API concepts.

## 🎉 Acknowledgments

Created for students learning web API development. Special thanks to the ASP.NET MVC framework and DotNetFiddle platform for making this interactive learning experience possible.