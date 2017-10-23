using Helios.Zero.Url;

namespace Helios.Zero.Application.Tests.Url
{
    public class FakeAppUrlService : IAppUrlService
    {
        public string CreateEmailActivationUrlFormat(int? tenantId)
        {
            return "http://test.com/";
        }

        public string CreatePasswordResetUrlFormat(int? tenantId)
        {
            return "http://test.com/";
        }

        public string CreateEmailActivationUrlFormat(string tenancyName)
        {
            return "http://test.com/";
        }

        public string CreatePasswordResetUrlFormat(string tenancyName)
        {
            return "http://test.com/";
        }
    }
}
