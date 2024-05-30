using TeledocTest.Core.Enums;

namespace TeledocTest.Core.Models;

///<summary>
/// Класс описывающий клиента
/// <summary>
public class Client : BaseEntity
{
    public string TaxId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public ClientType Type { get; set; }
    public IEnumerable<Founder>? Founders { get; set; } = default!;
}
