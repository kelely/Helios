using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Helios.Zero.Authorization.Permissions.Dto;

namespace Helios.Zero.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
