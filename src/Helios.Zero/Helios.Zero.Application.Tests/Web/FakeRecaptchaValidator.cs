using System.Threading.Tasks;
using Helios.Security.Recaptcha;

namespace Helios.Application.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
