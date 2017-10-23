using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Helios.Zero.Common.Dto;
using Helios.Zero.Editions.Dto;

namespace Helios.Zero.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}