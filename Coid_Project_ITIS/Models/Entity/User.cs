using Coid_Project_ITIS.Models.Entity.Map;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Coid_Project_ITIS.Models.Entity
{
    public class User : IdentityUser
    {
        public ICollection<Project> Project { get; set; }
        public ICollection<SkillUserMap> SkillUserMap { get; set; }
        public ICollection<TeamUserMap> TeamUserMap { get; set; }
    }
}
