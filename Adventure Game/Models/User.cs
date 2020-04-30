using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure_Game.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Screen { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int Health { get; set; }
    }
}
