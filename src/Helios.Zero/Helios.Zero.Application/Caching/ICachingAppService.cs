using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Helios.Zero.Caching.Dto;

namespace Helios.Zero.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
