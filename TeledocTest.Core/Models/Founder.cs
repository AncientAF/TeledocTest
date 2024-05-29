﻿namespace TeledocTest.Core.Models;
public class Founder : BaseEntity
{
    public string TaxId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string MiddleName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public IEnumerable<Client>? LegalEntities { get; set; } = default!;
}
