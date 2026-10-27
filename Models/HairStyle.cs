using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BarberRegister.Models;

public class HairStyle
{
    public int Id { get; set; }
    [Required(ErrorMessage = "A hairstyle name is required.")]
    [StringLength(60, MinimumLength = 2)]
    public string Name { get; set; } = "";
    [Required]
    [StringLength(300, MinimumLength = 10)]
    public string Description { get; set; } = "";
    [Required]
    [StringLength(30, MinimumLength = 2)]
    public string HairLength { get; set; } = "";
    [Range(5, 480)]
    public int TypicalDurationMinutes { get; set; }
    [Precision(7, 2)]
    [Range(10, 500)]
    public decimal StartingPrice { get; set; }
    public bool IncludesBeardService { get; set; }
    public ICollection<HairStyleReview> Reviews { get; set; } = new List<HairStyleReview>();
}
