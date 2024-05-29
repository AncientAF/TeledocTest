using TeledocTest.Infrastructure.Extensions;

namespace TeledocTest.Infrastructure.Repositories;
public class ClientRepository : IClientRepository
{
    private readonly TeledocTestDbContext _dbContext;

    public ClientRepository(TeledocTestDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Client>> Get(CancellationToken cancellationToken)
    {
        return await _dbContext.Clients.AsNoTracking().ToListAsync(cancellationToken);
    }
    public async Task<Client> GetById(Guid Id, CancellationToken cancellationToken)
    {
        var client = await _dbContext.Clients.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id, cancellationToken);

        if (client is null)
            throw new NotFoundException(nameof(Client), nameof(Id), Id);

        return client;
    }

    public async Task<Client> GetByTaxId(string TaxId, CancellationToken cancellationToken)
    {
        var client = await _dbContext.Clients.AsNoTracking().FirstOrDefaultAsync(c => c.TaxId == TaxId, cancellationToken);

        if (client is null)
            throw new NotFoundException(nameof(Client), nameof(TaxId), TaxId);

        return client;
    }

    public async Task<Guid> Create(Client client, CancellationToken cancellationToken)
    {
        await _dbContext.Clients.AddAsync(client, cancellationToken);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return client.Id;
    }

    public async Task<Client> Update(Client client, CancellationToken cancellationToken)
    {
        var clientToUpdate = await GetClient(client.Id, cancellationToken);

        clientToUpdate.Update(client);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return clientToUpdate;
    }

    public async Task<bool> Delete(Guid Id, CancellationToken cancellationToken)
    {
        var client = await GetClient(Id, cancellationToken);

        _dbContext.Remove(client);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return true;
    }

    private async Task<Client> GetClient(Guid Id, CancellationToken cancellationToken)
    {
        var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == Id, cancellationToken);

        if (client is null)
            throw new NotFoundException(nameof(Client), nameof(Id), Id);

        return client;
    }
}
