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
        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Screens.ToListAsync());
        //}

        public async Task<IActionResult> SpecScreen()
        {
            return View(await _context.Screens.ToListAsync());
        }
        public IActionResult Create(Screen screen)
        {
            _context.Add(screen);
            _context.SaveChanges();
            return View();
        }
    }
}