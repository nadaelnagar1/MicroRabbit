using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MicroRabbit.Transfer.Data.Context
{
    internal class TransferDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<TransferDbContext>();
            var connectionString = configuration.GetConnectionString("TransferDBConnection");

            builder.UseSqlServer(connectionString);

            return new TransferDbContext(builder.Options);
        }
    }
}
