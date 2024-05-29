using TeledocTest.Core.Models;

namespace TeledocTest.Core.Repositories;
public interface IFounderRepository
{
    Task<IEnumerable<Founder>> Get(CancellationToken cancellationToken);
    Task<Founder> GetById(Guid Id, CancellationToken cancellationToken);
    Task<Founder> GetByTaxId(string TaxId, CancellationToken cancellationToken);
    Task<Guid> Create(Founder founder, IList<Guid>? ClientsIds, CancellationToken cancellationToken);
    Task<Founder> Update(Founder founder, IList<Guid>? ClientsIds, CancellationToken cancellationToken);
    Task<bool> Delete(Guid Id, CancellationToken cancellationToken);
}
