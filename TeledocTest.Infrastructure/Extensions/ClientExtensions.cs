namespace TeledocTest.Infrastructure.Extensions;
internal static class ClientExtensions
{
    internal static void Update(this Client client, Client updated)
    {
        client.TaxId = updated.TaxId ?? client.TaxId;
        client.Name = updated.Name ?? client.Name;
        client.Type = updated.Type;
        client.Founders = updated.Founders ?? client.Founders;

        client.UpdatedAt = DateTime.UtcNow;
    }
}
