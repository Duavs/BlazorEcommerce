using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace BlazorEcommerce.Models;

public class Product
{
    public Product()
    {
        AvailableAfter = DateOnly.FromDateTime(DateTime.Now);
    }
    public int Id { get; set; }
    [Required] 
    public string Name { get; set; }
    [Range(1, 1000)]
    public decimal  Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<Product_Prop> ProductProperties { get; set; }
    
    public Category Category { get; set; }
    
    public DateOnly AvailableAfter { get; set; } 
}

public enum Category
{
    Entree,
    Appetizer,
    Dessert
}