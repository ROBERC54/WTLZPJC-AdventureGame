using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class Screen
    {
        [Key]
        public int ScreenId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
