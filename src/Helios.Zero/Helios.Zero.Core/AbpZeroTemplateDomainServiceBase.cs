using Abp.Domain.Services;

namespace Helios.Zero
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
