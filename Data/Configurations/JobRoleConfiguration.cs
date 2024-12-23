using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConfreneceAttendees.Data.Configurations
{
    public class JobRoleConfigurations : IEntityTypeConfiguration<JobRole>
    {
        public void Configure(EntityTypeBuilder<JobRole> builder)
        {
            builder.HasData(
                new JobRole {Id=1, Name = "Manager" },
                new JobRole {Id=2, Name = "Supervisor" },
                new JobRole {Id=3, Name = "Sales" },
                new JobRole {Id=4, Name = "Operations" }
                );
        }
    }
}
