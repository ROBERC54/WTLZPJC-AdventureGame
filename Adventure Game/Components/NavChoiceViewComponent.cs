using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Adventure_Game.Models;

namespace Adventure_Game.Components
{
    public class NavChoiceViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public NavChoiceViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(Screen screen)
        {

            return View(_context.AccessPoints
                .Where(x => x.From==screen.ScreenId));

        }
    }
}
