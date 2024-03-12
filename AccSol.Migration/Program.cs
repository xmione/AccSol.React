using AccSol.EF.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace AccSol.Migration
{
    internal class Program
    {
        [RequiresDynamicCode("Calls Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.Migrate()")]
        static void Main(string[] args)
        {
            // Create a service collection to add logging
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var programContext = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("Program");
            // Get a logger from the service provider
            var logger = serviceProvider.GetService<ILogger<Program>>() ?? programContext;

            // Use the logger
            logger.LogInformation("Starting the application...");

            // Call the method manually when you want to perform the migration
            MigrateDatabase(serviceProvider, logger);

            logger.LogInformation("Application started successfully.");
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add logging services
            services.AddLogging(configure => configure.AddConsole());

            // Add DbContext
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "DockerSql"}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        [RequiresDynamicCode("Calls Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.Migrate()")]
        private static void MigrateDatabase(IServiceProvider serviceProvider, ILogger logger)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                    logger.LogInformation("Database migration completed successfully.");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while migrating the database.");
                }
            }
        }
    }

}
