using System.Threading.Tasks;
using Helios.Zero.Sessions.Dto;

namespace Helios.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
