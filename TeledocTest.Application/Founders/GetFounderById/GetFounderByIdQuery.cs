﻿namespace TeledocTest.Application.Founders;
public record GetFounderByIdQuery(Guid Id) : IQuery<GetFounderByIdResponse>;
public record GetFounderByIdResponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<ClientResponse> LegalEntities, DateTime CreatedAt, DateTime UpdatedAt);
