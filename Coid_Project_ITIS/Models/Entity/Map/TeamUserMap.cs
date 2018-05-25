using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity.Map
{
    public class TeamUserMap
    {
        public int TeamId { get; set; }
        public string UserId { get; set; }

        public Team Team { get; set; }
        public User User { get; set; }
    }
}
