using BarberRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BarberRegister.Controllers;

public class HairStylesController : Controller
{
public IActionResult Index()
{
return View(HairStyleData.All);
}

public IActionResult Details(int id)
{
HairStyle? hairStyle = HairStyleData.All.FirstOrDefault(h => h.Id == id);
if (hairStyle is null)
{
return NotFound();
}
return View(hairStyle);
}
}