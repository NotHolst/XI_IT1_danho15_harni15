using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        { }

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<CmsContent> CmsContent { get; set; }
    }

    public class Subscription
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }

    public class CmsContent
    {
        public string Id { get; set; }
        public string Content { get; set; }
    }
}
