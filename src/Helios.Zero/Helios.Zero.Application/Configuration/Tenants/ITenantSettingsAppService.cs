using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Zero.Configuration.Tenants.Dto;

namespace Helios.Zero.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
