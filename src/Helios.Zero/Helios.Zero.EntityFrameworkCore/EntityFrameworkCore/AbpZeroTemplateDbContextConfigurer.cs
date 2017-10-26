using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Helios.EntityFrameworkCore
{
    public static class HeliosZeroDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HeliosZeroDbContext> builder, string connectionString)
        {
            // �޸�Ϊ֧��MySQLbuilder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HeliosZeroDbContext> builder, DbConnection connection)
        {
            // �޸�Ϊ֧��MySQLbuilder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}