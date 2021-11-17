using Duende.IdentityServer.EntityFramework.Entities;
using Duende.IdentityServer.EntityFramework.Extensions;
using Duende.IdentityServer.EntityFramework.Interfaces;
using Duende.IdentityServer.EntityFramework.Options;
using Manthano.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Manthano.Server.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int, IdentityUserClaim<int>, AppUserAppRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>, IPersistedGrantDbContext, IDisposable
    {
        private readonly IOptions<OperationalStoreOptions> _operationalStoreOptions;

        public AppDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options)
        {
            _operationalStoreOptions = operationalStoreOptions;
        }

        public DbSet<BibleBook> BibleBooks { get; set; }
        public DbSet<BibleChapter> BibleChapters { get; set; }
        public DbSet<BibleVerse> BibleVerses { get; set; }
        public DbSet<BibleReadingSession> BibleReadingSessions { get; set; }
        public DbSet<BibleTranslation> BibleTranslations { get; set; }
        public DbSet<BibleReadThrough> BibleReadThroughs { get; set; }
        public DbSet<BibleMemory> BibleMemories { get; set; }
        public DbSet<Church> Churches { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookReadThrough> BookReadThroughs { get; set; }
        public DbSet<BookReadingSession> BookReadingSessions { get; set; }

        public DbSet<PersistedGrant> PersistedGrants { get; set; }
        public DbSet<DeviceFlowCodes> DeviceFlowCodes { get; set; }
        public DbSet<Key> Keys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigurePersistedGrantContext(_operationalStoreOptions.Value);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Book).Assembly);
        }

        Task<int> IPersistedGrantDbContext.SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}