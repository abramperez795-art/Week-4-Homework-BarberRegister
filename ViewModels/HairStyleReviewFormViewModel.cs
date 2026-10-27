using BarberRegister.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BarberRegister.ViewModels;

public class HairStyleReviewFormViewModel
{
    public HairStyleReview Review { get; set; } = new();
    public SelectList? HairStyles { get; set; }
}
