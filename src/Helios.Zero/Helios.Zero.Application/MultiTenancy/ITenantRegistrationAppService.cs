using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Editions.Dto;
using Helios.MultiTenancy.Dto;

namespace Helios.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}