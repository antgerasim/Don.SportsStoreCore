using Don.SportsStoreCore.Configuration;
using Don.SportsStoreCore.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Don.SportsStoreCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SportsStoreCoreDbContextFactory : IDbContextFactory<SportsStoreCoreDbContext>
    {
        public SportsStoreCoreDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SportsStoreCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SportsStoreCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SportsStoreCoreConsts.ConnectionStringName));
            
            return new SportsStoreCoreDbContext(builder.Options);
        }
    }
}