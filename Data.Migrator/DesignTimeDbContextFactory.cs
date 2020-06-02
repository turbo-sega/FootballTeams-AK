using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Migrator
{
    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var connectionString = args.Any() ? args[0] : "FootballTeamsConnection";
            var options = new DbContextOptionsBuilder().UseSqlServer(connectionString,
                builder => builder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName))
                .Options;
            return new AppDbContext(options);
        }
    }
}