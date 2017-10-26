using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Helios.Authorization.Permissions.Dto;

namespace Helios.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
