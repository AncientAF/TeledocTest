namespace TeledocTest.Infrastructure.Extensions;
internal static class FounderExtensions
{
    internal static void Update(this Founder founder, Founder updated)
    {
        founder.TaxId = updated.TaxId ?? founder.TaxId;
        founder.Name = updated.Name ?? founder.Name;
        founder.MiddleName = updated.MiddleName ?? founder.MiddleName;
        founder.LastName = updated.LastName ?? founder.LastName;

        founder.LegalEntities = updated.LegalEntities ?? founder.LegalEntities;

        founder.UpdatedAt = DateTime.UtcNow;
    }
}
