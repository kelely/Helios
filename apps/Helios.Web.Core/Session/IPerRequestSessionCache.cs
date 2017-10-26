using System.Threading.Tasks;
using Helios.Sessions.Dto;

namespace Helios.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
