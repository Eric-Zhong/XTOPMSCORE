using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace XTOPMS.EntityFrameworkCore
{
    public static class XTOPMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<XTOPMSDbContext> builder, string connectionString)
        {
            // 因为默认的 ef core 不支持低版本的 SQL Server 分布，这里要修改成
            // builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());
            // builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<XTOPMSDbContext> builder, DbConnection connection)
        {
            // 因为默认的 ef core 不支持低版本的 SQL Server 分布，这里要修改成
            // builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
            // builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
