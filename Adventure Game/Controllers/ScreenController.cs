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

        public async Task<IActionResult> TakeItem(int? id)
        {
            return Details(id);
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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screen = await _context.Screens.FindAsync(id);
            if (screen == null)
            {
                return NotFound();
            }
            return View(screen);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScreenId,Name,Description")] Screen screen)
        {
            if (id != screen.ScreenId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreenExists(screen.ScreenId))
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
            return View(screen);
        }
        private bool ScreenExists(int id)
        {
            return _context.Screens.Any(e => e.ScreenId == id);
        }
    }
}