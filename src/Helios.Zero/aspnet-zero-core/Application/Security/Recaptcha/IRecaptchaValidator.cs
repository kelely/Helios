using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Helios.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        /// <summary>
        /// 对图形验证码进行验证
        /// </summary>
        /// <param name="captchaResponse"></param>
        /// <returns></returns>
        Task ValidateAsync(string captchaResponse);
    }
}