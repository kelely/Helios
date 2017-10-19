using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Configuration.Tenants.Dto;

namespace Helios.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
