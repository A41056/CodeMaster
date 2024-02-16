using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CodeMaster.Data.CodeMasterDbContext
{
    public class CodeMasterDbContextFactory : IDesignTimeDbContextFactory<CodeMasterDbContext>
    {
        public CodeMasterDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CodeMasterDb");

            var optionsBuilder = new DbContextOptionsBuilder<CodeMasterDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CodeMasterDbContext(optionsBuilder.Options);
        }
    }
}
