using Coid_Project_ITIS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coid_Project_ITIS.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDbContext _dbcontext)
        {
            _dbcontext.Database.EnsureCreated();

            if (!_dbcontext.Tag.Any())
            {
                _dbcontext.Tag.AddRange(new List<Tag>
                {
                    new Tag { Name = "asp.net-core" },
                    new Tag { Name = "c#" },
                    new Tag { Name = "motor" },
                    new Tag { Name = "twitter" }
                });
                _dbcontext.SaveChanges();
            }

            if (!_dbcontext.Skill.Any())
            {
                _dbcontext.Skill.AddRange(new List<Skill>
                {
                    new Skill { Name = "asp.net-cre" },
                    new Skill { Name = "c#" },
                    new Skill { Name = "html" },
                    new Skill { Name = "css" },
                    new Skill { Name = "javascript" },
                    new Skill { Name = "entityframework" }
                });
                _dbcontext.SaveChanges();
            }

        }
    }
}
