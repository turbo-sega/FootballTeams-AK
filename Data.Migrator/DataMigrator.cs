using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Data.Migrator
{
    class DataMigrator
    {
        static async Task Main(string[] args)
        {
            var connectionString = await GetConnectionString();
            var dbContext = await EnsureDbCreatedAndMigrated(connectionString);
            Console.WriteLine($"DB '{dbContext.Database.GetDbConnection().Database}' has been migrated");
            
            Console.WriteLine();
            var appliedMigrations = (await dbContext.Database.GetAppliedMigrationsAsync()).ToList();
            if (appliedMigrations.Any())
            {
                Console.WriteLine("Applied Migrations:");
                appliedMigrations.ForEach(m => Console.WriteLine($" * {m}"));
            }
            else
            {
                Console.WriteLine("No Applied Migrations");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static async Task<string> GetConnectionString()
        {
            var connectionString = "Server=(local);Database=FootballTeams;Trusted_Connection=true;MultipleActiveResultSets=true";

            var appSettingsContent = await File.ReadAllTextAsync("appsettings.json");
            var appSettingsObj = (JObject)JsonConvert.DeserializeObject(appSettingsContent);
            if (appSettingsObj?.ContainsKey("ConnectionStrings") ?? false)
            {
                var csObj = appSettingsObj["ConnectionStrings"];
                connectionString = csObj["FootballTeamsConnection"].Value<string>();
            }
            return connectionString;
        }

        private static async Task<AppDbContext> EnsureDbCreatedAndMigrated(string connectionString)
        {
            var dbContext = new DesignTimeDbContextFactory().CreateDbContext(new[] {connectionString});
            await dbContext.Database.MigrateAsync();
            return dbContext;
        }
    }
}