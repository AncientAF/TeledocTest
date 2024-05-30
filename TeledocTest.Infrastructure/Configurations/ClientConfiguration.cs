using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TeledocTest.Infrastructure.Configurations;
internal class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => c.TaxId).IsUnique();

        builder.HasMany(c => c.Founders).WithMany(f => f.LegalEntities).UsingEntity<ClientFounder>();
    }
}
