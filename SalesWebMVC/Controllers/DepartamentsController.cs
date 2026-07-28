
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

public class DepartamentsController : Controller
{
    private readonly SalesWebMVCContext _context;

    public DepartamentsController(SalesWebMVCContext context)
    {
        _context = context;
    }

    // GET: DEPARTAMENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Departament.ToListAsync());
    }

    // GET: DEPARTAMENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var departament = await _context.Departament
            .FirstOrDefaultAsync(m => m.Id == id);
        if (departament == null)
        {
            return NotFound();
        }

        return View(departament);
    }

    // GET: DEPARTAMENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: DEPARTAMENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name")] Departament departament)
    {
        if (ModelState.IsValid)
        {
            _context.Add(departament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(departament);
    }

    // GET: DEPARTAMENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var departament = await _context.Departament.FindAsync(id);
        if (departament == null)
        {
            return NotFound();
        }
        return View(departament);
    }

    // POST: DEPARTAMENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name")] Departament departament)
    {
        if (id != departament.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(departament);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentExists(departament.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(departament);
    }

    // GET: DEPARTAMENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var departament = await _context.Departament
            .FirstOrDefaultAsync(m => m.Id == id);
        if (departament == null)
        {
            return NotFound();
        }

        return View(departament);
    }

    // POST: DEPARTAMENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var departament = await _context.Departament.FindAsync(id);
        if (departament != null)
        {
            _context.Departament.Remove(departament);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool DepartamentExists(int? id)
    {
        return _context.Departament.Any(e => e.Id == id);
    }
}
