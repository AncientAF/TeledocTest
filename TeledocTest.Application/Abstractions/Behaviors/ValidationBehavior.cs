﻿using Microsoft.Extensions.Logging;

namespace TeledocTest.Application.Abstractions.Behaviors;
public class ValidationBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    private readonly ILogger<ValidationBehavior<TRequest, TResponse>> _logger;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators, ILogger<ValidationBehavior<TRequest, TResponse>> logger)
    {
        _validators = validators;
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);

        var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));

        var failures = validationResults.Where(r => r.Errors.Any()).SelectMany(r => r.Errors).ToList();

        if (failures.Any())
        {
            _logger.LogError("Completed request {RequestName} with errors {Errors}", typeof(TRequest).Name, failures);
            throw new ValidationException(failures);
        }

        return await next();
    }
}
