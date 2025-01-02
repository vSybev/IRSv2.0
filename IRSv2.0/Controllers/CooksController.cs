using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IRSv2._0.Data;
using IRSv2._0.Models;

namespace IRSv2._0.Controllers
{
    public class CooksController : Controller
    {
        private readonly IRSDbContext _context;

        public CooksController(IRSDbContext context)
        {
            _context = context;
        }

        // GET: Cooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cooks.ToListAsync());
        }

        // GET: Cooks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cook = await _context.Cooks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cook == null)
            {
                return NotFound();
            }

            return View(cook);
        }

        // GET: Cooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Cook cook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cook);
        }

        // GET: Cooks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cook = await _context.Cooks.FindAsync(id);
            if (cook == null)
            {
                return NotFound();
            }
            return View(cook);
        }

        // POST: Cooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name")] Cook cook)
        {
            if (id != cook.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CookExists(cook.ID))
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
            return View(cook);
        }

        // GET: Cooks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cook = await _context.Cooks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cook == null)
            {
                return NotFound();
            }

            return View(cook);
        }

        // POST: Cooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cook = await _context.Cooks.FindAsync(id);
            if (cook != null)
            {
                _context.Cooks.Remove(cook);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CookExists(string id)
        {
            return _context.Cooks.Any(e => e.ID == id);
        }
    }
}
