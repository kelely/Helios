using System.Threading.Tasks;

namespace Helios.Zero.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}