using Microsoft.EntityFrameworkCore;
using TeledocTest.API.Extensions;
using TeledocTest.Core.Repositories;
using TeledocTest.Infrastructure.Data;
using TeledocTest.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
var dbConnection = builder.Configuration.GetConnectionString("Database");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TeledocTestDbContext>(configuration =>
{
    configuration.UseNpgsql(dbConnection);
});

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IFounderRepository, FounderRepository>();

var app = builder.Build();

app.UseMigration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
