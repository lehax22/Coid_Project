using Coid_Project_ITIS.Models.Entity.Map;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity
{
    public enum Status
    {
        Waiting,
        Development,
        Release
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status? Status { get; set; }
        [Display(Name = "Username")]
        public string UserId { get; set; }

        public Team Team { get; set; }
        public User User { get; set; }

        public ICollection<TagProjectMap> TagProjectMap { get; set; }
        public ICollection<SkillProjectMap> SkillProjectMap { get; set; }

        public Project()
        {
            TagProjectMap = new HashSet<TagProjectMap>();
            SkillProjectMap = new HashSet<SkillProjectMap>();
        }
    }
}
