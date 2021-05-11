using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortCartier.Data;
using PortCartier.Models.Entities;

namespace PortCartier.Controllers
{
    public class DocumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Documents
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Documents.Include(d => d.Category);
            return View(await applicationDbContext.OrderByDescending(model => model.Created).ToListAsync());
        }

        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Documents
                .Include(d => d.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // GET: Documents/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.DocumentCategories, "Id", "Title");
            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,YearOfPublication,CategoryId,Type,Description,ISBN")] Document document, IFormFile image)
        {
            if (image == null || image.Length == 0)
                ModelState.AddModelError("Image", "image is required");

            if (ModelState.IsValid)
            {
                await SaveDocumentImage(document, image);

                _context.Add(document);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.DocumentCategories, "Id", "Title", document.CategoryId);
            return View(document);
        }

        // GET: Documents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Documents.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.DocumentCategories, "Id", "Title", document.CategoryId);
            return View(document);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Image,Author,YearOfPublication,CategoryId,Type,Description,ISBN,Created,CreatedBy")] Document document, IFormFile image)
        {
            if (id != document.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (image != null)
                    {
                        await SaveDocumentImage(document, image);
                    }

                    _context.Update(document);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentExists(document.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.DocumentCategories, "Id", "Title", document.CategoryId);
            return View(document);
        }

        private async Task SaveDocumentImage(Document document, IFormFile image)
        {
            var fileName = $"{DateTime.Now.Ticks}-{image.FileName}";

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "documents", fileName);

            using var stream = new FileStream(path, FileMode.Create);

            await image.CopyToAsync(stream);

            document.Image = $"/images/documents/{fileName}";
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Documents
                .Include(d => d.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var document = await _context.Documents.FindAsync(id);
            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentExists(int id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }
    }
}
