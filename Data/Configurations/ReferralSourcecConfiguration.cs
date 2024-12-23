using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConfreneceAttendees.Data.Configurations
{
    public class ReferralSourceConfigurations : IEntityTypeConfiguration<ReferralSouerce>
    {
        public void Configure(EntityTypeBuilder<ReferralSouerce> builder)
        {
            builder.HasData(
                new ReferralSouerce {Id=1, Name = "Internet Advertisement" },
                new ReferralSouerce {Id=2, Name = "Television" },
                new ReferralSouerce {Id=3, Name = "Newspaper Article" },
                new ReferralSouerce {Id=4, Name = "Other" }
                );
        }
    }
}
