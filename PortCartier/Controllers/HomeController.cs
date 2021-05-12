using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PortCartier.Data;
using PortCartier.Models.Enums;
using PortCartier.Models.ViewModels;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortCartier.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Documents.OrderByDescending(model => model.Created).ToListAsync());
        }

        public async Task<IActionResult> DocumentDetails(int id)
        {
            var document = await _context.Documents.SingleOrDefaultAsync(model => model.Id == id);

            if (document == null) return NotFound();

            var request = await _context.Requests.FirstOrDefaultAsync(model => model.DocumentId == document.Id && model.Status == RequestStatus.Waiting);

            ViewData["Requestable"] = true;

            var currentDate = DateTime.Now;

            var loaned = await _context.Loans.AnyAsync(model => model.DocumentId == document.Id && model.ExpectedReturnDate > currentDate);

            if (request != null || loaned) ViewData["Requestable"] = false;

            return View(document);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
