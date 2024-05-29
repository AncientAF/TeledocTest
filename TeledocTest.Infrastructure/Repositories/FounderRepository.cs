using TeledocTest.Core.Models;
using TeledocTest.Infrastructure.Extensions;

namespace TeledocTest.Infrastructure.Repositories;

public class FounderRepository : IFounderRepository
{
    private readonly TeledocTestDbContext _dbContext;

    public FounderRepository(TeledocTestDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Founder>> Get(CancellationToken cancellationToken)
    {
        return await _dbContext.Founders.AsNoTracking().Include(f => f.LegalEntities).ToListAsync(cancellationToken);
    }

    public async Task<Founder> GetById(Guid Id, CancellationToken cancellationToken)
    {
        var founder = await _dbContext.Founders.AsNoTracking().Include(f => f.LegalEntities).FirstOrDefaultAsync(c => c.Id == Id, cancellationToken);

        if (founder is null)
            throw new NotFoundException(nameof(Founder), nameof(Id), Id);

        return founder;
    }

    public async Task<Founder> GetByTaxId(string TaxId, CancellationToken cancellationToken)
    {
        var founder = await _dbContext.Founders.AsNoTracking().Include(f => f.LegalEntities).FirstOrDefaultAsync(c => c.TaxId == TaxId, cancellationToken);

        if (founder is null)
            throw new NotFoundException(nameof(Founder), nameof(TaxId), TaxId);

        return founder;
    }
    public async Task<Guid> Create(Founder founder, IList<Guid>? ClientsIds, CancellationToken cancellationToken)
    {
        if (ClientsIds != null)
            founder.LegalEntities = await _dbContext.Clients.Where(f => ClientsIds.Contains(f.Id)).ToListAsync();

        await _dbContext.Founders.AddAsync(founder, cancellationToken);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return founder.Id;
    }

    public async Task<Founder> Update(Founder founder, IList<Guid>? ClientsIds, CancellationToken cancellationToken)
    {
        var founderToUpdate = await GetFounder(founder.Id, cancellationToken);

        if (ClientsIds != null)
            founderToUpdate.LegalEntities = await _dbContext.Clients.Where(f => ClientsIds.Contains(f.Id)).ToListAsync();
        else
            founderToUpdate.LegalEntities = Array.Empty<Client>();

        founderToUpdate.Update(founder);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return founderToUpdate;
    }

    public async Task<bool> Delete(Guid Id, CancellationToken cancellationToken)
    {
        var founder = await GetFounder(Id, cancellationToken);

        _dbContext.Remove(founder);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return true;
    }

    private async Task<Founder> GetFounder(Guid Id, CancellationToken cancellationToken)
    {
        var founder = await _dbContext.Founders.Include(f => f.LegalEntities).FirstOrDefaultAsync(c => c.Id == Id, cancellationToken);

        if (founder is null)
            throw new NotFoundException(nameof(Founder), nameof(Id), Id);

        return founder;
    }
}
