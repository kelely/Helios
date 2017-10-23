using System.Threading.Tasks;

namespace Helios.Zero.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}