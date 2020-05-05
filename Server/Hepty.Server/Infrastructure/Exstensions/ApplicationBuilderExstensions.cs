namespace Hepty.Infrastructure.Exstensions
{
    using Hepty.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection; 

    public static class ApplicationBuilderExstensions
    {
        public static void ApplyMigration (this IApplicationBuilder app)
        {
            using var service = app.ApplicationServices.CreateScope();
            var dbContext = service.ServiceProvider.GetService<HeptyDbContext>();
            dbContext.Database.Migrate();
        }

         public static IApplicationBuilder UseSwaggerUI(this IApplicationBuilder app)
            => app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My Hepty API");
                    options.RoutePrefix = string.Empty;
                });
    }
}
