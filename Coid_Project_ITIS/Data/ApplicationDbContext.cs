using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Coid_Project_ITIS.Models.Entity;
using Coid_Project_ITIS.Models.Entity.Map;

namespace Coid_Project_ITIS.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //TagProjectMap
            builder.Entity<TagProjectMap>()
                .HasKey(t => new { t.TagId, t.ProjectId });
            builder.Entity<TagProjectMap>()
                .HasOne(sc => sc.Tag)
                .WithMany(s => s.TagProjectMap)
                .HasForeignKey(s => s.TagId);
            builder.Entity<TagProjectMap>()
                .HasOne(sc => sc.Project)
                .WithMany(s => s.TagProjectMap)
                .HasForeignKey(s => s.ProjectId);

            //SkillUserMap
            builder.Entity<SkillUserMap>()
                .HasKey(t => new { t.SkillId, t.UserId });
            builder.Entity<SkillUserMap>()
                .HasOne(sc => sc.Skill)
                .WithMany(s => s.SkillUserMap)
                .HasForeignKey(s => s.SkillId);
            builder.Entity<SkillUserMap>()
                .HasOne(sc => sc.User)
                .WithMany(s => s.SkillUserMap)
                .HasForeignKey(s => s.UserId);

            //SkillProjectMap
            builder.Entity<SkillProjectMap>()
                .HasKey(t => new { t.SkillId, t.ProjectId });
            builder.Entity<SkillProjectMap>()
                .HasOne(sc => sc.Skill)
                .WithMany(s => s.SkillProjectMap)
                .HasForeignKey(s => s.SkillId);
            builder.Entity<SkillProjectMap>()
                .HasOne(sc => sc.Project)
                .WithMany(s => s.SkillProjectMap)
                .HasForeignKey(s => s.ProjectId);

            //TeamUserMap
            builder.Entity<TeamUserMap>()
                .HasKey(t => new { t.TeamId, t.UserId });
            builder.Entity<TeamUserMap>()
                .HasOne(sc => sc.Team)
                .WithMany(s => s.TeamUserMap)
                .HasForeignKey(s => s.TeamId);
            builder.Entity<TeamUserMap>()
                .HasOne(sc => sc.User)
                .WithMany(s => s.TeamUserMap)
                .HasForeignKey(s => s.UserId);
        }
    }
}
