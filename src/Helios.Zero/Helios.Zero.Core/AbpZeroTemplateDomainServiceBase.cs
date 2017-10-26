using Abp.Domain.Services;

namespace Helios
{
    public abstract class HeliosZeroDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected HeliosZeroDomainServiceBase()
        {
            LocalizationSourceName = HeliosZeroConsts.LocalizationSourceName;
        }
    }
}
