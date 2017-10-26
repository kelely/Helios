using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Configuration.Host.Dto;

namespace Helios.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
