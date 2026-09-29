using System.ComponentModel.DataAnnotations;

namespace BarberRegister.Models;

public class HairStyle
{
    public int Id { get; set; }

    [Required(ErrorMessage = "A hairstyle name is required.")]
    [StringLength(60, MinimumLength = 2,
        ErrorMessage = "The style name must be between 2 and 60 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "A description is required.")]
    [StringLength(300, MinimumLength = 10,
        ErrorMessage = "The description must be between 10 and 300 characters.")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Hair length is required.")]
    [StringLength(30, MinimumLength = 2,
        ErrorMessage = "Hair length must be between 2 and 30 characters.")]
    public string HairLength { get; set; } = string.Empty;

    [Range(5, 480,
        ErrorMessage = "Typical service time must be between 5 and 480 minutes.")]
    public int TypicalDurationMinutes { get; set; }

    [Range(10, 500,
        ErrorMessage = "The starting price must be between 10 and 500.")]
    public decimal StartingPrice { get; set; }

    public bool IncludesBeardService { get; set; }
}