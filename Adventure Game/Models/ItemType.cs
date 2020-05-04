using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class ItemType
    {
        [Key]
        public int ItemTypeId { get; set; }
        public string ItemDescription { get; set; }
    }
}
