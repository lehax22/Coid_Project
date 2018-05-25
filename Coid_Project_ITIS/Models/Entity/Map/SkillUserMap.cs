using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity.Map
{
    public class SkillUserMap
    {
        public int SkillId { get; set; }
        public string UserId { get; set; }

        public User User { get; set; }
        public Skill Skill { get; set; }
    }
}
