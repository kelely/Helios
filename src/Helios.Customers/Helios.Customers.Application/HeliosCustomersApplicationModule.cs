using System;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Helios.Authorization;

namespace Helios
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(HeliosCustomersCoreModule)
    )]
    public class HeliosCustomersApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            // 权限集提供者
            Configuration.Authorization.Providers.Add<HeliosCustomersAppAuthorizationProvider>();

            ////Adding custom AutoMapper configuration
            //Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HeliosCustomersApplicationModule).GetAssembly());
        }
    }
}
