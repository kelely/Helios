using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Sessions.Dto;

namespace Helios.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
