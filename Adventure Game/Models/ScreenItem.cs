using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure_Game.Models
{
    public class ScreenItem
    {
        public int ScreenItemId { get; set; }
        public int ScreenId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public string TakenDescription { get; set; }
        public string Action { get; set; }

    }
}
