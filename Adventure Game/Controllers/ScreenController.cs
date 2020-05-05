using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Adventure_Game.Models;
using Microsoft.EntityFrameworkCore;

namespace Adventure_Game.Controllers
{
    public class ScreenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScreenController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Screens.ToListAsync());
        }

        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Screens.ToListAsync());
        //}

        public async Task<IActionResult> SpecScreen()
        {
            return View(await _context.Screens.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enemy = await _context.Screens
                .FirstOrDefaultAsync(m => m.ScreenId == id);
            if (enemy == null)
            {
                return NotFound();
            }

            return View(enemy);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScreenId,Name,Description")]Screen screen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screen);
        }
    }
}