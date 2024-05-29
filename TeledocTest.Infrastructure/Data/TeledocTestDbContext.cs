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

        base.OnModelCreating(modelBuilder);
    }
}
