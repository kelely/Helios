using Abp.MultiTenancy;
using Abp.Zero.Configuration;

namespace Helios.Authorization.Roles
{
    public static class HeliosCustomersAppRoleConfig
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
                    HeliosCustomersStaticRoleNames.Tenants.Customer,
                    MultiTenancySides.Tenant)
            );

            roleManagementConfig.StaticRoles.Add(
                new StaticRoleDefinition(
                    HeliosCustomersStaticRoleNames.Tenants.CustomerSupervisor,
                    MultiTenancySides.Tenant)
            );
        }
    }
}
