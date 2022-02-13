
using System.ComponentModel.DataAnnotations;
namespace ContosoPizza.Models;


public class Sauce
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name field is required.")]
    [StringLength(maximumLength: 100, MinimumLength = 2)]
    public string? Name { get; set; }

    public bool IsVegan { get; set; }
}