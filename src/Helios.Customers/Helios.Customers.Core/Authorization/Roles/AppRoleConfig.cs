using Abp.MultiTenancy;
using Abp.Zero.Configuration;

namespace Helios.Authorization.Roles
{
    public static class AppRoleConfig
    {
        public static void Configure(IRoleManagementConfig roleManagementConfig)
        {
            ////Static host roles

            //roleManagementConfig.StaticRoles.Add(
            //    new StaticRoleDefinition(
            //        StaticRoleNames.Host.Admin,
            //        MultiTenancySides.Host)
            //);

            //Static tenant roles

            roleManagementConfig.StaticRoles.Add(
                new StaticRoleDefinition(
                    StaticRoleNames.Tenants.Customer,
                    MultiTenancySides.Tenant)
            );

            roleManagementConfig.StaticRoles.Add(
                new StaticRoleDefinition(
                    StaticRoleNames.Tenants.CustomerSupervisor,
                    MultiTenancySides.Tenant)
            );
        }
    }
}
