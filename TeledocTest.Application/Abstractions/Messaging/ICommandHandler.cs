﻿namespace TeledocTest.Application.Abstractions.Messaging;
public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit> where TCommand : ICommand<Unit>;
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>;