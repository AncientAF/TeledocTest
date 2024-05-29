using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeledocTest.Infrastructure.Extensions;
internal static class FounderExtensions
{
    internal static void Update(this Founder founder, Founder updated)
    {
        founder.TaxId = updated.TaxId ?? founder.TaxId;
        founder.Name = updated.Name ?? founder.Name;
        founder.MiddleName = updated.MiddleName ?? founder.MiddleName;
        founder.LastName = updated.LastName ?? founder.LastName;

        founder.UpdatedAt = DateTime.UtcNow;
    }
}
