using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure_Game.Models
{
    public class InventoryItem
    {
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public int ScreenItemId { get; set; }
        public int Quantity { get; set; }
    }
}
