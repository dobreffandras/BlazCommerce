using System.ComponentModel.DataAnnotations;

namespace BlazCommerce.Shared;

public class NewProduct
{
    [Required(AllowEmptyStrings = false)]
    public string Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; } // TODO turn to multiple
}