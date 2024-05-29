using TeledocTest.Core.Enums;

namespace TeledocTest.Core.Models;
public class Client : BaseEntity
{
    public string TaxID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public ClientType Type { get; set; }
}
