using Microsoft.EntityFrameworkCore;
using ConfreneceAttendees.Data;

namespace ConfreneceAttendees.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ConfreneceAttendees.Data.Attendee> Attendee { get; set; } = default!;
        public DbSet<ConfreneceAttendees.Data.Gender> Gender { get; set; } = default!;
        public DbSet<ConfreneceAttendees.Data.JobRole> JobRole { get; set; } = default!;
        public DbSet<ConfreneceAttendees.Data.ReferralSouerce> ReferralSouerce { get; set; } = default!;
    }
}
