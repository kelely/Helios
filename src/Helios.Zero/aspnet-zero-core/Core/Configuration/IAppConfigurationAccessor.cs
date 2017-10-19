using Microsoft.Extensions.Configuration;

namespace Helios.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
