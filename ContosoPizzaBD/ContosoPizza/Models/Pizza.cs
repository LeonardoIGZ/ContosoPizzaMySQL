global using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name field is required.")]
    [StringLength(maximumLength: 100, MinimumLength = 2)]
    public string? Name { get; set; }

    public Sauce? Sauce { get; set; }
    
    public ICollection<Topping>? Toppings { get; set; }
}