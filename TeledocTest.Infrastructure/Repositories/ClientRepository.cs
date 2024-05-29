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
        return await _dbContext.Clients.AsNoTracking().Include(c => c.Founders).ToListAsync(cancellationToken);
    }
    public async Task<Client> GetById(Guid Id, CancellationToken cancellationToken)
    {
        var client = await _dbContext.Clients.AsNoTracking().Include(c => c.Founders).FirstOrDefaultAsync(c => c.Id == Id, cancellationToken);

        if (client is null)
            throw new NotFoundException(nameof(Client), nameof(Id), Id);

        return client;
    }

    public async Task<Client> GetByTaxId(string TaxId, CancellationToken cancellationToken)
    {
        var client = await _dbContext.Clients.AsNoTracking().Include(c => c.Founders).FirstOrDefaultAsync(c => c.TaxId == TaxId, cancellationToken);

        if (client is null)
            throw new NotFoundException(nameof(Client), nameof(TaxId), TaxId);

        return client;
    }

    public async Task<Guid> Create(Client client, IList<Guid>? foundersIds, CancellationToken cancellationToken)
    {
        if(foundersIds != null)
            client.Founders = await _dbContext.Founders.Where(f => foundersIds.Contains(f.Id)).ToListAsync();

        await _dbContext.Clients.AddAsync(client, cancellationToken);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return client.Id;
    }

    public async Task<Client> Update(Client client, IList<Guid>? foundersIds, CancellationToken cancellationToken)
    {
        var clientToUpdate = await GetClient(client.Id, cancellationToken);

        if (foundersIds != null)
            clientToUpdate.Founders = await _dbContext.Founders.Where(f => foundersIds.Contains(f.Id)).ToListAsync();
        else
            clientToUpdate.Founders = Array.Empty<Founder>();

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
        var client = await _dbContext.Clients.Include(c => c.Founders).FirstOrDefaultAsync(c => c.Id == Id, cancellationToken);

        if (client is null)
            throw new NotFoundException(nameof(Client), nameof(Id), Id);

        return client;
    }
}
