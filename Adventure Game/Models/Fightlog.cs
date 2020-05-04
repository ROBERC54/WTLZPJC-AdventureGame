using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class Fightlog
    {
        [Key]
        public int UserId { get; set; }
        public int ScreenEnemyId { get; set; }
        public int DamageDone { get; set; }
    }
}
