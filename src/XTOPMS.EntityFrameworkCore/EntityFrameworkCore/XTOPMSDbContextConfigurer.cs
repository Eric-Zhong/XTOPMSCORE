using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace XTOPMS.EntityFrameworkCore
{
    public static class XTOPMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<XTOPMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<XTOPMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
