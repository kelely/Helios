using System.Threading.Tasks;
using Helios.Zero.Security.Recaptcha;

namespace Helios.Zero.Application.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
