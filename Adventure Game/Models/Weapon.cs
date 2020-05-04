using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class Weapon
    {
        [Key]
        public int ItemId { get; set; }
        public int Multiplier { get; set; }
        public int Dice { get; set; }
    }
}
