using BarberRegister.Data;
using BarberRegister.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarberRegister.Controllers;

public class HairStylesController : Controller
{
    private readonly BarberRegisterContext _context;

    public HairStylesController(BarberRegisterContext context)
        => _context = context;

    // TEMPORARY LOCAL TEST — restore before committing or deploying.
 
public async Task<IActionResult> Index() => View(await _context.HairStyles
    .Include(h => h.Reviews).OrderBy(h => h.Name).ToListAsync());
    
    // Leave your existing Create, Edit, and Delete methods below unchanged.
    [HttpGet]
    public IActionResult Create() => View(new HairStyle());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Name,Description,HairLength,TypicalDurationMinutes,StartingPrice,IncludesBeardService")] HairStyle item)
    {
        if (!ModelState.IsValid) return View(item);
        _context.HairStyles.Add(item);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var item = await _context.HairStyles.FindAsync(id);
        if (item == null) return NotFound();
        return View(item);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,HairLength,TypicalDurationMinutes,StartingPrice,IncludesBeardService")] HairStyle form)
    {
        if (id != form.Id) return NotFound();
        if (!ModelState.IsValid) return View(form);
        var item = await _context.HairStyles.FindAsync(id);
        if (item == null) return NotFound();
        item.Name = form.Name;
        item.Description = form.Description;
        item.HairLength = form.HairLength;
        item.TypicalDurationMinutes = form.TypicalDurationMinutes;
        item.StartingPrice = form.StartingPrice;
        item.IncludesBeardService = form.IncludesBeardService;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _context.HairStyles.Include(h => h.Reviews).FirstOrDefaultAsync(h => h.Id == id);
        if (item == null) return NotFound();
        return View(item);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var item = await _context.HairStyles.FindAsync(id);
        if (item == null) return NotFound();
        _context.HairStyles.Remove(item);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
