using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCompanyName.AbpZeroTemplate.EntityFrameworkCore
{
    public static class AbpZeroTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, string connectionString)
        {
            // TODO:修改为支持MySQL by Ryan(21071019) builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, DbConnection connection)
        {
            // TODO:修改为支持MySQL by Ryan(21071019) builder.UseSqlServer(connection);
        }
    }
}