using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Helios.Zero.Configuration;
using Helios.Zero.Web;

namespace Helios.Zero.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HeliosZeroDbContextFactory : IDesignTimeDbContextFactory<HeliosZeroDbContext>
    {
        public HeliosZeroDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HeliosZeroDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HeliosZeroDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HeliosZeroConsts.ConnectionStringName));

            return new HeliosZeroDbContext(builder.Options);
        }
    }
}