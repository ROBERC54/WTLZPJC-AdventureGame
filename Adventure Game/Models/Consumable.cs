using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class Consumable
    {
        [Key]
        public int ItemId { get; set; }
        public int Heals { get; set; }
        
    }
}
