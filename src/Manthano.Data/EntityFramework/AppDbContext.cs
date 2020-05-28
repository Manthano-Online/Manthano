using Manthano.Data.EntityFramework.Models;
using Manthano.Data.EntityFramework.TypeMappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Manthano.Data.EntityFramework
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AppUserTypeConfiguration());
            builder.ApplyConfiguration(new AppRoleTypeConfiguration());
        }
    }
}
