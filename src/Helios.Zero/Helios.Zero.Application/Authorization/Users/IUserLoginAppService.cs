using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Helios.Zero.Authorization.Users.Dto;

namespace Helios.Zero.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
