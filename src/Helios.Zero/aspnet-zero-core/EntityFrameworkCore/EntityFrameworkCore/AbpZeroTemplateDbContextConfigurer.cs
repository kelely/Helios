using System.Data.Common;
using Microsoft.EntityFrameworkCore;

// ReSharper disable once CheckNamespace
namespace Helios.EntityFrameworkCore
{
    public static class AbpZeroTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, string connectionString)
        {
            // 修改为支持MySQLbuilder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, DbConnection connection)
        {
            // 修改为支持MySQLbuilder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}