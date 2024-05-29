namespace TeledocTest.Application.Founders;
public record GetFoundersQuery() : IQuery<GetFoundersResponse>;
public record GetFoundersResponse(IEnumerable<Founder> Founders);