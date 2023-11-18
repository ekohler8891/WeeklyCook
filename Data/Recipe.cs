using System.ComponentModel.DataAnnotations;

namespace WeeklyCook.Data;

public class Recipe
{
    [Required] public String Name { get; set; }
    [Required] public String Instructions { get; set; }
    [Required] public String Ingredients { get; set; }
    public String Notes { get; set; }
}