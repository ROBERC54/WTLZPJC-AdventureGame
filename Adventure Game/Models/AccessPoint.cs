﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adventure_Game.Models
{
    public class AccessPoint
    {
        [Key]
        public int AccessPointId { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Description { get; set; }
    }
}
