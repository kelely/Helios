using System.Threading.Tasks;
using Abp.Configuration;

namespace Helios.Zero.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
