using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.IdentityServer4;
using Abp.Localization;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Helios.Authorization.Roles;
using Helios.Authorization.Users;
using Helios.MultiTenancy;

// ReSharper disable once CheckNamespace
namespace Helios.EntityFrameworkCore
{
    public partial class AbpZeroTemplateDbContext : AbpZeroDbContext<Tenant, Role, User, AbpZeroTemplateDbContext>, IAbpPersistedGrantDbContext
    {
        private void ConfigurePersistedGrantEntity(ModelBuilder modelBuilder)
        {
            // NOTE: 此段源码的初始版本来自于 https://github.com/aspnetboilerplate/aspnetboilerplate/blob/dev/src/Abp.ZeroCore.IdentityServer4.EntityFrameworkCore/IdentityServer4/AbpZeroCoreIdentityServerEntityFrameworkCoreConfigurationExtensions.cs

            modelBuilder.Entity<PersistedGrantEntity>(grant =>
            {
                // Id 长度不能超过191， 因为192 * 4 = 768 > 767
                grant.Property(x => x.Id).HasMaxLength(200).ValueGeneratedNever();
                grant.Property(x => x.Type).HasMaxLength(50).IsRequired();
                grant.Property(x => x.SubjectId).HasMaxLength(100/*200*/);
                grant.Property(x => x.ClientId).HasMaxLength(100/*200*/).IsRequired();
                grant.Property(x => x.CreationTime).IsRequired();
                // 50000 chosen to be explicit to allow enough size to avoid truncation, yet stay beneath the MySql row size limit of ~65K
                // apparently anything over 4K converts to nvarchar(max) on SqlServer
                grant.Property(x => x.Data).HasMaxLength(50000).IsRequired();

                grant.HasKey(x => x.Id);

                // 引发 "Specified key was too long; max key length is 767 bytes" 异常
                // 主要就是需要注释这句话，不要创建索引，但是不创建索引的话有可能会有性能问题
                // https://stackoverflow.com/a/19940875
                grant.HasIndex(x => new { x.SubjectId, x.ClientId, x.Type });
            });
        }

        private void ConfigureHeliosEntity(ModelBuilder modelBuilder)
        {
            //-----------------------------------
            // 在MySQL环境下对这些字段创建索引时会出错：Specified key was too long; max key length is 767 bytes
            // 因为 256 * 3 > 767， 所以需要将这些字段修改为 255 长度
            //-----------------------------------
            modelBuilder.Entity<ApplicationLanguageText>(b =>
            {
                b.Property(x => x.Key).HasMaxLength(255).IsRequired();
            });

            modelBuilder.Entity<Setting>(b =>
            {
                b.Property(x => x.Name).HasMaxLength(255).IsRequired();
            });

            modelBuilder.Entity<UserLogin>(b =>
            {
                b.Property(x => x.ProviderKey).HasMaxLength(255).IsRequired();
            });

            modelBuilder.Entity<User>(b =>
            {
                b.Property(x => x.NormalizedUserName).HasMaxLength(255).IsRequired();
                b.Property(x => x.NormalizedEmailAddress).HasMaxLength(255).IsRequired();
            });
        }
    }
}
