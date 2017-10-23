using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Zero.Editions.Dto;
using Helios.Zero.MultiTenancy.Dto;

namespace Helios.Zero.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}