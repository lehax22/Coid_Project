using Coid_Project_ITIS.Models.Entity.Map;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity
{
    public class Team
    {
        public int Id { get; set; }
        [Display(Name = "Project Name")]
        public int ProjectId { get; set; }
        [Display(Name = "Lead")]
        public string UserId { get; set; }

        public Project Project { get; set; }
        public User User { get; set; }
        public ICollection<TeamUserMap> TeamUserMap { get; set; }
        
    }
}
