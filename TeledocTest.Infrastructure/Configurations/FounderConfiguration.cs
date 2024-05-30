using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TeledocTest.Infrastructure.Configurations;
internal class FounderConfiguration : IEntityTypeConfiguration<Founder>
{
    public void Configure(EntityTypeBuilder<Founder> builder)
    {
        builder.HasKey(f => f.Id);

        builder.HasIndex(f => f.TaxId).IsUnique();

        builder.HasMany(f => f.LegalEntities).WithMany(c => c.Founders).UsingEntity<ClientFounder>(); ;
    }
}
