using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using XTOPMS.Configuration;
using XTOPMS.Web;

namespace XTOPMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class XTOPMSDbContextFactory : IDesignTimeDbContextFactory<XTOPMSDbContext>
    {
        public XTOPMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<XTOPMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            XTOPMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(XTOPMSConsts.ConnectionStringName));

            return new XTOPMSDbContext(builder.Options);
        }
    }
}
