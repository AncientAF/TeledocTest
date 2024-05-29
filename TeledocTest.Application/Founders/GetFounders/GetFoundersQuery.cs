namespace TeledocTest.Application.Founders.GetFounders;
public record GetFoundersQuery() : IQuery<GetFoundersResponse>;
public record GetFoundersResponse(IEnumerable<Founder> Founders);