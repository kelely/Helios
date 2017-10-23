using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.Configuration;
using Helios.Membership.Authorization.Roles;
using Helios.Membership.Localization;

namespace Helios.Membership
{
    public class HeliosMembershipCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            // 配置会员模块的多语言定义
            HeliosMembershipLocalizationConfigurer.Configure(Configuration.Localization);

            // 配置会员模块的角色定义
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HeliosMembershipCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
        }
    }
}