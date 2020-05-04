using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public int ItemTypeId { get; set; }
        public string Name { get; set; }

    }
}
