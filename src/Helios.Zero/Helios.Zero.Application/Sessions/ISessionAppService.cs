using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Zero.Sessions.Dto;

namespace Helios.Zero.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
