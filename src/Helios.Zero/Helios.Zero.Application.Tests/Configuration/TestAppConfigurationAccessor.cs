using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Helios.Zero.Configuration;

namespace Helios.Zero.Application.Tests.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(HeliosZeroTestModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
