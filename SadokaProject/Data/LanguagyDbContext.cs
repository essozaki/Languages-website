using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Languagy_project.Data.Entities;

namespace Languagy_project.Data
{
    public class LanguagyDbContext:IdentityDbContext
    {
        public LanguagyDbContext(DbContextOptions<LanguagyDbContext> opts) : base(opts) { }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<ContactUS> ContactUS { get; set; }
        public DbSet<Welcome> Welcome { get; set; }
        public DbSet<Theme> Theme { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
    }
}
