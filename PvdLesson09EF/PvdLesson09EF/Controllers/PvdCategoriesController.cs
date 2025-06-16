using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PvdLesson09EF.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PvdLesson09EF.Controllers
{
    public class PvdCategoriesController : Controller
    {
        private readonly PvdBookStoreContext _context;

        public PvdCategoriesController(PvdBookStoreContext context)
        {
            _context = context;
        }

        // GET: PvdCategories
        public async Task<IActionResult> PvdIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: PvdCategories/Details/5
        public async Task<IActionResult> Details(int? Pvdid)
        {
            if (Pvdid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == Pvdid);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: PvdCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PvdCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PvdIndex));
            }
            return View(category);
        }

        // GET: PvdCategories/Edit/5
        public async Task<IActionResult> Edit(int? Pvdid)
        {
            if (Pvdid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(Pvdid);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: PvdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Pvdid, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (Pvdid != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(PvdIndex));
            }
            return View(category);
        }

        // GET: PvdCategories/Delete/5
        public async Task<IActionResult> Delete(int? Pvdid)
        {
            if (Pvdid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == Pvdid);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: PvdCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Pvdid)
        {
            var category = await _context.Categories.FindAsync(Pvdid);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PvdIndex));
        }

        private bool CategoryExists(int Pvdid)
        {
            return _context.Categories.Any(e => e.CategoryId == Pvdid);
        }
    }
}
