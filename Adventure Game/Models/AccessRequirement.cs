using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure_Game.Models
{
    public class AccessRequirement
    {
        public int AccessRequirementId { get; set; }
        public int AccessPointId { get; set; }
        public int ItemId { get; set; }

        public string ClosedMessage { get; set; }
        public string OpenMessage { get; set; }
    }
}
