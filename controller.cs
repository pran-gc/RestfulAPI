using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HelloWorldMvcApp
{
    public class HomeController : Controller
    {
        // In-memory data storage (simulating database)
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone 14", Price = 999.99m, Category = "Electronics", Stock = 25, Description = "Latest iPhone model" },
            new Product { Id = 2, Name = "Samsung TV", Price = 799.99m, Category = "Electronics", Stock = 15, Description = "55 inch Smart TV" },
            new Product { Id = 3, Name = "Nike Shoes", Price = 129.99m, Category = "Clothing", Stock = 30, Description = "Running shoes" },
            new Product { Id = 4, Name = "Coffee Maker", Price = 89.99m, Category = "Appliances", Stock = 12, Description = "Automatic coffee maker" },
            new Product { Id = 5, Name = "Gaming Chair", Price = 249.99m, Category = "Furniture", Stock = 8, Description = "Ergonomic gaming chair" }
        };

        private static List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890" },
            new Customer { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "098-765-4321" }
        };

        private static int _nextProductId = 6;
        private static int _nextCustomerId = 3;

        // Main view
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // =============================================================================
        // DEMO EXAMPLES (4 complete examples for teacher demonstration)
        // =============================================================================

        // DEMO 1: GET - Get all products
        [HttpGet]
        public JsonResult GetAllProducts()
        {
            try
            {
                return Json(_products, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = "Internal server error: " + ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        // DEMO 2: POST - Add a new product
        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product.Id = _nextProductId++;
                    _products.Add(product);
                    Response.StatusCode = 201; // Created
                    return Json(new { message = "Product created successfully", product = product });
                }
                else
                {
                    Response.StatusCode = 400; // Bad Request
                    return Json(new { error = "Invalid product data" });
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = "Internal server error: " + ex.Message });
            }
        }

        // DEMO 3: PUT - Update an existing product
        [HttpPut]
        public JsonResult UpdateProduct(int id, Product updatedProduct)
        {
            try
            {
                var existingProduct = _products.FirstOrDefault(p => p.Id == id);
                if (existingProduct == null)
                {
                    Response.StatusCode = 404; // Not Found
                    return Json(new { error = "Product not found" });
                }

                if (ModelState.IsValid)
                {
                    existingProduct.Name = updatedProduct.Name;
                    existingProduct.Price = updatedProduct.Price;
                    existingProduct.Category = updatedProduct.Category;
                    existingProduct.Stock = updatedProduct.Stock;
                    existingProduct.Description = updatedProduct.Description;

                    return Json(new { message = "Product updated successfully", product = existingProduct });
                }
                else
                {
                    Response.StatusCode = 400; // Bad Request
                    return Json(new { error = "Invalid product data" });
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = "Internal server error: " + ex.Message });
            }
        }

        // DEMO 4: DELETE - Remove a product by ID
        [HttpDelete]
        public JsonResult DeleteProduct(int id)
        {
            try
            {
                var product = _products.FirstOrDefault(p => p.Id == id);
                if (product == null)
                {
                    Response.StatusCode = 404; // Not Found
                    return Json(new { error = "Product not found" });
                }

                _products.Remove(product);
                return Json(new { message = "Product deleted successfully", deletedProduct = product });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = "Internal server error: " + ex.Message });
            }
        }

        // =============================================================================
        // STUDENT PRACTICE EXERCISES (16 exercises - 4 per HTTP method)
        // =============================================================================

        // GET EXERCISES
        // ============================================================================

        // GET Easy 1: Get product by ID (variation of demo)
        [HttpGet]
        public JsonResult GetProductById(int id)
        {
            
            // Find product by ID and return it
            // Return 404 if not found
            
            return Json(new { message = "Not implemented yet" }, JsonRequestBehavior.AllowGet);
        }

        // GET Easy 2: Get products by category (another variation)
        [HttpGet]
        public JsonResult GetProductsByCategory(string category)
        {
            
            // Filter products by category
            // Return empty list if no products found in category
            
            return Json(new { message = "Not implemented yet" }, JsonRequestBehavior.AllowGet);
        }

        // GET Medium: Get products with filtering/search parameters
        [HttpGet]
        public JsonResult SearchProducts(string name = "", decimal? minPrice = null, decimal? maxPrice = null)
        {
            
            // Filter products by name (contains), minPrice, and maxPrice
            // Use LINQ Where clauses for filtering
            
            return Json(new { message = "Not implemented yet" }, JsonRequestBehavior.AllowGet);
        }

        // GET Challenge: Get products with price range filter
        [HttpGet]
        public JsonResult GetProductsInPriceRange(decimal minPrice, decimal maxPrice)
        {
            
            // Return products where price is between minPrice and maxPrice (inclusive)
            // Validate that minPrice <= maxPrice
            
            return Json(new { message = "Not implemented yet" }, JsonRequestBehavior.AllowGet);
        }

        // POST EXERCISES
        // ============================================================================

        // POST Easy 1: Add product with basic validation (variation of demo)
        [HttpPost]
        public JsonResult AddProductWithValidation(Product product)
        {
            
            // Add product but check if name already exists
            // Return 409 (Conflict) if product name already exists
            
            return Json(new { message = "Not implemented yet" });
        }

        // POST Easy 2: Add customer instead of product (variation)
        [HttpPost]
        public JsonResult AddCustomer(Customer customer)
        {
            
            // Similar to AddProduct but for Customer entity
            // Validate ModelState and assign new ID
            
            return Json(new { message = "Not implemented yet" });
        }

        // POST Medium: Add product with required field validation
        [HttpPost]
        public JsonResult AddProductWithRequiredFields(Product product)
        {
            
            // Check that Name, Price, and Category are not null/empty
            // Return specific error messages for missing fields
            
            return Json(new { message = "Not implemented yet" });
        }

        // POST Challenge: Add product with price validation rules
        [HttpPost]
        public JsonResult AddProductWithPriceValidation(Product product)
        {
            
            // Validate that price is between $1 and $5000
            // Return 400 with specific error message if price is out of range
            
            return Json(new { message = "Not implemented yet" });
        }

        // PUT EXERCISES
        // ============================================================================

        // PUT Easy 1: Update product name only (variation of demo)
        [HttpPut]
        public JsonResult UpdateProductName(int id, string name)
        {
            
            // Find product by ID and update only the name
            // Validate that name is not null or empty
            
            return Json(new { message = "Not implemented yet" });
        }

        // PUT Easy 2: Update product price only (variation)
        [HttpPut]
        public JsonResult UpdateProductPrice(int id, decimal price)
        {
            
            // Find product by ID and update only the price
            // Validate that price is greater than 0
            
            return Json(new { message = "Not implemented yet" });
        }

        // PUT Medium: Update product with validation
        [HttpPut]
        public JsonResult UpdateProductWithValidation(int id, Product updatedProduct)
        {
            
            // Update product but validate all fields before updating
            // Check ModelState and return appropriate error messages
            
            return Json(new { message = "Not implemented yet" });
        }

        // PUT Challenge: Update product with stock quantity check
        [HttpPut]
        public JsonResult UpdateProductWithStockCheck(int id, Product updatedProduct)
        {
            
            // Update product but ensure stock is never negative
            // Return 400 if trying to set negative stock
            
            return Json(new { message = "Not implemented yet" });
        }

        // DELETE EXERCISES
        // ============================================================================

        // DELETE Easy 1: Delete by product name (variation of demo)
        [HttpDelete]
        public JsonResult DeleteProductByName(string name)
        {
            
            // Find and delete product by name
            // Return 404 if product with that name doesn't exist
            
            return Json(new { message = "Not implemented yet" });
        }

        // DELETE Easy 2: Delete customer by ID (variation)
        [HttpDelete]
        public JsonResult DeleteCustomer(int id)
        {
            
            // Similar to DeleteProduct but for Customer entity
            // Return appropriate success/error messages
            
            return Json(new { message = "Not implemented yet" });
        }

        // DELETE Medium: Delete with existence check first
        [HttpDelete]
        public JsonResult DeleteProductWithCheck(int id)
        {
            
            // Check if product exists before attempting to delete
            // Return informative messages about the operation
            
            return Json(new { message = "Not implemented yet" });
        }

        // DELETE Challenge: Delete with simple business rule check
        [HttpDelete]
        public JsonResult DeleteProductWithBusinessRule(int id)
        {
            
            // Don't allow deletion if product stock > 0 (business rule)
            // Return 409 (Conflict) if trying to delete product with stock
            
            return Json(new { message = "Not implemented yet" });
        }

        // =============================================================================
        // UTILITY METHODS (Helper methods for the exercises)
        // =============================================================================

        private bool ProductExists(string name)
        {
            return _products.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        private bool CustomerExists(string email)
        {
            return _customers.Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}