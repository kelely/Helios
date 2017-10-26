using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Helios.EntityFrameworkCore
{
    public static class HeliosZeroDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HeliosZeroDbContext> builder, string connectionString)
        {
            // 修改为支持MySQLbuilder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HeliosZeroDbContext> builder, DbConnection connection)
        {
            // 修改为支持MySQLbuilder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}