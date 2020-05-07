using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Adventure_Game.Models;

namespace Adventure_Game.Components
{
    public class UserDataDisplayViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public UserDataDisplayViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public string Invoke()
        {
            return "UserDataDisplay will manifest here:" +
                "\nUserId:" +
                "\nName:" +
                "\nScreen:" +
                "\nLevel:" +
                "\nExp:" +
                "\nHP:";
        }
        public IViewComponentResult InvokeusethisinplaceofInvokelater()//will replace Invoke()
        {

            return View(_context);

        }
    }
}
