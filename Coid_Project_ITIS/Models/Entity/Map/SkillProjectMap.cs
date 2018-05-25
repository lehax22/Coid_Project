using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity.Map
{
    public class SkillProjectMap
    {
        public int SkillId { get; set; }
        public int ProjectId { get; set; }

        public Skill Skill { get; set; }
        public Project Project { get; set; }
    }
}
