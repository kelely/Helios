using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.Configuration;
using Helios.Authorization.Roles;
using Helios.Localization;

namespace Helios
{
    public class HeliosCustomersCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            // 配置会员模块的多语言定义
            HeliosCustomersLocalizationConfigurer.Configure(Configuration.Localization);

            // 配置会员模块的角色定义
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HeliosCustomersCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
        }
    }
}