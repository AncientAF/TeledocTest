using Microsoft.EntityFrameworkCore;
using TeledocTest.Core.Enums;

namespace TeledocTest.Infrastructure.Data;
public class TeledocTestDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Founder> Founders { get; set; }

    public TeledocTestDbContext(DbContextOptions<TeledocTestDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeledocTestDbContext).Assembly);

        modelBuilder.Entity<Client>(builder =>
        {
            builder.HasData(
                new Client { Id = Guid.Parse("86297138-9adc-4b12-a0e8-8217ce0a6002"), TaxId = "1234567890", Name = "Client 1", Type = ClientType.LegalEntity },
                new Client { Id = Guid.Parse("eed4569e-de5e-4155-9c03-1dd658dc774c"), TaxId = "2345678901", Name = "Client 2", Type = ClientType.LegalEntity },
                new Client { Id = Guid.Parse("ee1dab06-c8c2-47dd-8282-16c627c79be9"), TaxId = "3456789012", Name = "Client 3", Type = ClientType.LegalEntity },
                new Client { Id = Guid.Parse("1c164bab-0747-40e2-b885-f1fec5440d42"), TaxId = "344461123113", Name = "Client 4", Type = ClientType.Individual },
                new Client { Id = Guid.Parse("93aa14b2-6430-4bf3-bab7-3cd4fb92a804"), TaxId = "125678312356", Name = "Client 5", Type = ClientType.Individual }
            );
        });

        modelBuilder.Entity<Founder>(builder =>
        {
            builder.HasData(
                new Founder { Id = Guid.Parse("0cd5c44a-c498-4d21-a47a-a0dda3c2d790"), TaxId = "123456789022", Name = "Founder 1", MiddleName = "M", LastName = "L" },
                new Founder { Id = Guid.Parse("cd72aff6-e787-405e-a4d8-77eec25460c5"), TaxId = "234567890133", Name = "Founder 2", MiddleName = "M", LastName = "L" },
                new Founder { Id = Guid.Parse("4d8bb61a-2df3-4a06-949a-23e8af1b686f"), TaxId = "345678901244", Name = "Founder 3", MiddleName = "M", LastName = "L" },
                new Founder { Id = Guid.Parse("da3cce6d-2e15-4616-80a4-a76b2b669959"), TaxId = "234567890155", Name = "Founder 4", MiddleName = "M", LastName = "L" },
                new Founder { Id = Guid.Parse("6d11dd64-336f-47df-8864-507b3fcc766e"), TaxId = "345678901266", Name = "Founder 5", MiddleName = "M", LastName = "L" },
                new Founder { Id = Guid.Parse("9b466d1b-1a35-4fa0-bda9-38e172e3799b"), TaxId = "345678901277", Name = "Founder 6", MiddleName = "M", LastName = "L" }
            );
        });

        modelBuilder.Entity<ClientFounder>(builder =>
        {
            builder.HasData(
                new ClientFounder { ClientId = Guid.Parse("86297138-9adc-4b12-a0e8-8217ce0a6002"), FounderId = Guid.Parse("0cd5c44a-c498-4d21-a47a-a0dda3c2d790") },
                new ClientFounder { ClientId = Guid.Parse("86297138-9adc-4b12-a0e8-8217ce0a6002"), FounderId = Guid.Parse("cd72aff6-e787-405e-a4d8-77eec25460c5") },
                new ClientFounder { ClientId = Guid.Parse("eed4569e-de5e-4155-9c03-1dd658dc774c"), FounderId = Guid.Parse("4d8bb61a-2df3-4a06-949a-23e8af1b686f") },
                new ClientFounder { ClientId = Guid.Parse("ee1dab06-c8c2-47dd-8282-16c627c79be9"), FounderId = Guid.Parse("da3cce6d-2e15-4616-80a4-a76b2b669959") },
                new ClientFounder { ClientId = Guid.Parse("eed4569e-de5e-4155-9c03-1dd658dc774c"), FounderId = Guid.Parse("6d11dd64-336f-47df-8864-507b3fcc766e") },
                new ClientFounder { ClientId = Guid.Parse("86297138-9adc-4b12-a0e8-8217ce0a6002"), FounderId = Guid.Parse("9b466d1b-1a35-4fa0-bda9-38e172e3799b") }
            );
        });


        base.OnModelCreating(modelBuilder);
    }
}
