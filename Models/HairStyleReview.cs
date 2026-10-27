using System.ComponentModel.DataAnnotations;

namespace BarberRegister.Models;

public class HairStyleReview
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Reviewer name")]
    [StringLength(60, MinimumLength = 2)]
    public string ReviewerName { get; set; } = "";
    [Range(1, 5, ErrorMessage = "Choose a rating from 1 to 5.")]
    public int Rating { get; set; }
    [Required]
    [StringLength(500, MinimumLength = 10,
        ErrorMessage = "Write a review between 10 and 500 characters.")]
    public string Comments { get; set; } = "";
    [DataType(DataType.Date)]
    [Display(Name = "Reviewed on")]
    public DateTime ReviewedOn { get; set; }
    [Display(Name = "Hairstyle")]
    [Range(1, int.MaxValue, ErrorMessage = "Choose a hairstyle.")]
    public int HairStyleId { get; set; }
    public HairStyle? HairStyle { get; set; }
}
