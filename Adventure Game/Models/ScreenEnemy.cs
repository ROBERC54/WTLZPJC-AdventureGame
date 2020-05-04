using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class ScreenEnemy
    {
        [Key]
        public int ScreenEnemyId { get; set; }
        public int ScreenId { get; set; }
        public int EnemyId { get; set; }
        public string Action { get; set; }
        
    }
}
