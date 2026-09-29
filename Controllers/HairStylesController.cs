using BarberRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BarberRegister.Controllers;

public class HairStylesController : Controller
{
private static List<HairStyle> hairStyles = new List<HairStyle>
{
    new HairStyle
    {
        Id = 1,
        Name = "Low Fade",
        Description = "A clean tapered haircut.",
        HairLength = "Short",
        TypicalDurationMinutes = 45,
        StartingPrice = 35,
        IncludesBeardService = false
    },
    new HairStyle
    {
        Id = 2,
        Name = "Box Braids",
        Description = "A protective braided hairstyle.",
        HairLength = "Medium to long",
        TypicalDurationMinutes = 180,
        StartingPrice = 120,
        IncludesBeardService = false
    }
};

    public IActionResult Index()
    {
        return View(hairStyles);
    }

    public IActionResult Details(int id)
    {
        HairStyle? hairStyle = hairStyles.FirstOrDefault(x => x.Id == id);

        if (hairStyle == null)
        {
            return NotFound();
        }

        return View(hairStyle);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(HairStyle item)
    {
        if (!ModelState.IsValid)
        {
            return View(item);
        }

        item.Id = hairStyles.Max(x => x.Id) + 1;

        hairStyles.Add(item);

        return RedirectToAction(nameof(Index));
    }
}