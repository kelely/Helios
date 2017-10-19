using System.Threading.Tasks;

namespace Helios.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}