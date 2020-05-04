using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class ScreenItem
    {
        [Key]
        public int ScreenItemId { get; set; }
        public int ScreenId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public string TakenDescription { get; set; }
        public string Action { get; set; }

    }
}
