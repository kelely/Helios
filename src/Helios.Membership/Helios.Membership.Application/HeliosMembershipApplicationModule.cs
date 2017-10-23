using Abp.Modules;
using Abp.Reflection.Extensions;
using Helios.Membership.Authorization;

namespace Helios.Membership
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(HeliosMembershipCoreModule)
    )]
    public class HeliosMembershipApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            // 权限集提供者
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            ////Adding custom AutoMapper configuration
            //Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HeliosMembershipApplicationModule).GetAssembly());
        }
    }
}