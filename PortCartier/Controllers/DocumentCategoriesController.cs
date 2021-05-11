using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortCartier.Data;
using PortCartier.Models.Entities;

namespace PortCartier.Controllers
{
    public class DocumentCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocumentCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DocumentCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.DocumentCategories.ToListAsync());
        }

        // GET: DocumentCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentCategory = await _context.DocumentCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documentCategory == null)
            {
                return NotFound();
            }

            return View(documentCategory);
        }

        // GET: DocumentCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocumentCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] DocumentCategory documentCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documentCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(documentCategory);
        }

        // GET: DocumentCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentCategory = await _context.DocumentCategories.FindAsync(id);
            if (documentCategory == null)
            {
                return NotFound();
            }
            return View(documentCategory);
        }

        // POST: DocumentCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Created,CreatedBy")] DocumentCategory documentCategory)
        {
            if (id != documentCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documentCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentCategoryExists(documentCategory.Id))
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
            return View(documentCategory);
        }

        // GET: DocumentCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentCategory = await _context.DocumentCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documentCategory == null)
            {
                return NotFound();
            }

            return View(documentCategory);
        }

        // POST: DocumentCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var documentCategory = await _context.DocumentCategories.FindAsync(id);
            _context.DocumentCategories.Remove(documentCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentCategoryExists(int id)
        {
            return _context.DocumentCategories.Any(e => e.Id == id);
        }
    }
}
