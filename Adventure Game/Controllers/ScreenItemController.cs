using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Adventure_Game.Models;

namespace Adventure_Game.Controllers
{
    public class ScreenItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScreenItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.ScreenItems);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ScreenItem screenItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screenItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screenItem);
        }

        public IActionResult Test(ScreenItem screenItem)
        {
            return View(screenItem);
        }
    }
}