using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCompanyName.AbpZeroTemplate.EntityFrameworkCore
{
    public static class AbpZeroTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, string connectionString)
        {
            // TODO:�޸�Ϊ֧��MySQL by Ryan(21071019) builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, DbConnection connection)
        {
            // TODO:�޸�Ϊ֧��MySQL by Ryan(21071019) builder.UseSqlServer(connection);
        }
    }
}