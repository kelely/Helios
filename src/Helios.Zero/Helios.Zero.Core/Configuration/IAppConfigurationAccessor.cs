using Microsoft.Extensions.Configuration;

namespace Helios.Zero.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
