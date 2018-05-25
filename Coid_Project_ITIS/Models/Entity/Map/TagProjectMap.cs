using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Models.Entity.Map
{
    public class TagProjectMap
    {
        public int TagId { get; set; }
        public int ProjectId { get; set; }

        public Tag Tag { get; set; }
        public Project Project { get; set; }
    }
}
