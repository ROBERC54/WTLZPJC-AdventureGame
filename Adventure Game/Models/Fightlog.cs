using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure_Game.Models
{
    public class Fightlog
    {
        public int UserId { get; set; }
        public int ScreenEnemyId { get; set; }
        public int DamageDone { get; set; }
    }
}
