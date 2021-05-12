using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortCartier.Core.Interfaces;
using PortCartier.Data;
using PortCartier.Models.Entities;
using PortCartier.Models.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PortCartier.Controllers
{
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;

        public RequestController(ApplicationDbContext context,
                                 ICurrentUserService currentUserService)
        {
            _context = context;

            _currentUserService = currentUserService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Submit(int documentId)
        {
            try
            {
                var document = await _context.Documents.FindAsync(documentId);

                if (document == null) return Json(new { success = false });

                _context.Requests.Add(new Request
                {
                    DocumentId = documentId,
                    UserId = _currentUserService.UserId
                });

                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        public async Task<IActionResult> List()
        {
            return View(await _context.Requests.Include(model => model.User).Include(model => model.Document).OrderByDescending(model => model.Id).ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> ChangeRequestStatus(bool status, DateTime? returnedDate, int requestId)
        {
            var request = await _context.Requests.FindAsync(requestId);

            if (request == null) return Json(new { });

            if (status)
            {
                request.Status = RequestStatus.Confirmed;

                _context.Loans.Add(new Loan
                {
                    DocumentId = request.DocumentId,
                    ExpectedReturnDate = returnedDate.Value,
                    UserId = request.UserId
                });
            }
            else
            {
                request.Status = RequestStatus.Rejected;
            }

            await _context.SaveChangesAsync();

            return Json(new { });
        }
    }
}