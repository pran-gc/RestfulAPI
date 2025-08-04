using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldMvcApp
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Range(0.01, 10000)]
        public decimal Price { get; set; }
        
        public string Category { get; set; }
        
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
        
        public string Description { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        public string Phone { get; set; }
    }
}