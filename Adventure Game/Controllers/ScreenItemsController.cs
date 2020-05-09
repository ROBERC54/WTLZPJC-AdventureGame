using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Adventure_Game.Models;

namespace Adventure_Game.Controllers
{
    public class ScreenItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScreenItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ScreenItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScreenItems.ToListAsync());
        }

        // GET: ScreenItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenItem = await _context.ScreenItems
                .FirstOrDefaultAsync(m => m.ScreenItemId == id);
            if (screenItem == null)
            {
                return NotFound();
            }

            return View(screenItem);
        }

        // GET: ScreenItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScreenItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScreenItemId,ScreenId,ItemId,Description,TakenDescription,Action")] ScreenItem screenItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screenItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screenItem);
        }

        // GET: ScreenItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenItem = await _context.ScreenItems.FindAsync(id);
            if (screenItem == null)
            {
                return NotFound();
            }
            return View(screenItem);
        }

        // POST: ScreenItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScreenItemId,ScreenId,ItemId,Description,TakenDescription,Action")] ScreenItem screenItem)
        {
            if (id != screenItem.ScreenItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screenItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreenItemExists(screenItem.ScreenItemId))
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
            return View(screenItem);
        }

        // GET: ScreenItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenItem = await _context.ScreenItems
                .FirstOrDefaultAsync(m => m.ScreenItemId == id);
            if (screenItem == null)
            {
                return NotFound();
            }

            return View(screenItem);
        }

        // POST: ScreenItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var screenItem = await _context.ScreenItems.FindAsync(id);
            _context.ScreenItems.Remove(screenItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScreenItemExists(int id)
        {
            return _context.ScreenItems.Any(e => e.ScreenItemId == id);
        }
    }
}
