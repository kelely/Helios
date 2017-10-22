using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Helios.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        /// <summary>
        /// ��ͼ����֤�������֤
        /// </summary>
        /// <param name="captchaResponse"></param>
        /// <returns></returns>
        Task ValidateAsync(string captchaResponse);
    }
}