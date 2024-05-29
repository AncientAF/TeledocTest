using Microsoft.EntityFrameworkCore;
using TeledocTest.Infrastructure.Data;

namespace TeledocTest.API.Extensions;

internal static class MigrationExtension
{
    public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        using var dbContext = scope.ServiceProvider.GetRequiredService<TeledocTestDbContext>();
        dbContext.Database.MigrateAsync();

        return app;
    }
}
