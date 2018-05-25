using Coid_Project_ITIS.Models.Entity.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SkillUserMap> SkillUserMap { get; set; }
        public ICollection<SkillProjectMap> SkillProjectMap { get; set; }
    }
}
