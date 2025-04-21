using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MicroRabbit.Banking.Data.Context
{
    internal class BankingDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BankingDbContext>();
            var connectionString = configuration.GetConnectionString("BankingDBConnection");

            builder.UseSqlServer(connectionString);

            return new BankingDbContext(builder.Options);
        }
    }
}
