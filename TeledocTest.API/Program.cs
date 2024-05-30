using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Text.Json.Serialization;
using TeledocTest.API.Extensions;
using TeledocTest.API.Middleware;
using TeledocTest.Application.Abstractions.Behaviors;
using TeledocTest.Application.Clients;
using TeledocTest.Core.Repositories;
using TeledocTest.Infrastructure.Data;
using TeledocTest.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
var dbConnection = builder.Configuration.GetConnectionString("Database");

// Add services to the container.

builder.Host.UseSerilog((context, loggerConfig) =>
    loggerConfig.ReadFrom.Configuration(context.Configuration));

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(CreateClientCommand).Assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(RequestLoggingPipelineBehavior<,>));
});
builder.Services.AddValidatorsFromAssembly(typeof(CreateClientCommand).Assembly);

builder.Services.AddControllers();//.AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TeledocTestDbContext>(configuration =>
{
    configuration.UseNpgsql(dbConnection);
});

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IFounderRepository, FounderRepository>();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

app.UseMigration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseExceptionHandler();

app.MapControllers();

app.Run();
