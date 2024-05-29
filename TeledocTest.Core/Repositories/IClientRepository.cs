using TeledocTest.Core.Models;

namespace TeledocTest.Core.Repositories;

public interface IClientRepository
{
    Task<IEnumerable<Client>> Get(CancellationToken cancellationToken);
    Task<Client> GetById(Guid Id, CancellationToken cancellationToken);
    Task<Client> GetByTaxId(string TaxId, CancellationToken cancellationToken);
    Task<Guid> Create(Client client, CancellationToken cancellationToken);
    Task<Client> Update(Client client, CancellationToken cancellationToken);
    Task<bool> Delete(Guid Id, CancellationToken cancellationToken);
}
