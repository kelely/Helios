using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Zero.Configuration.Host.Dto;

namespace Helios.Zero.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
