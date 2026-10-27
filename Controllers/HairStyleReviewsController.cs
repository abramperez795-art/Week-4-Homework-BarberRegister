using BarberRegister.Data;
using BarberRegister.Models;
using BarberRegister.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BarberRegister.Controllers;

public class HairStyleReviewsController : Controller
{
    private readonly BarberRegisterContext _context;
    public HairStyleReviewsController(BarberRegisterContext context) => _context = context;

    [HttpGet]
    public IActionResult Create(int? hairStyleId)
    {
        return View(new HairStyleReviewFormViewModel
        {
            Review = new HairStyleReview { HairStyleId = hairStyleId ?? 0, ReviewedOn = DateTime.Today },
            HairStyles = Choices(hairStyleId)
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(HairStyleReviewFormViewModel form)
    {
        if (!await _context.HairStyles.AnyAsync(h => h.Id == form.Review.HairStyleId))
            ModelState.AddModelError("Review.HairStyleId", "Choose an existing hairstyle.");
        if (!ModelState.IsValid)
        {
            form.HairStyles = Choices(form.Review.HairStyleId);
            return View(form);
        }
        var review = new HairStyleReview
        {
            HairStyleId = form.Review.HairStyleId,
            ReviewerName = form.Review.ReviewerName,
            Rating = form.Review.Rating,
            Comments = form.Review.Comments,
            ReviewedOn = form.Review.ReviewedOn
        };
        _context.HairStyleReviews.Add(review);
        await _context.SaveChangesAsync();
        return RedirectToAction("Details", "HairStyles", new { id = review.HairStyleId });
    }

    private SelectList Choices(int? selected) => new(
        _context.HairStyles.OrderBy(h => h.Name).ToList(), "Id", "Name", selected);
}
