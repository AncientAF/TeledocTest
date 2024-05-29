using MediatR;

namespace TeledocTest.Application.Abstractions.Messaging;
internal interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull;
