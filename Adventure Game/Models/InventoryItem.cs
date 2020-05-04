using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class InventoryItem
    {
        [Key]
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public int ScreenItemId { get; set; }
        public int Quantity { get; set; }
    }
}
