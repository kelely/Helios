using Abp.Domain.Services;

namespace Helios
{
    public abstract class HeliosCustomersDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected HeliosCustomersDomainServiceBase()
        {
            LocalizationSourceName = HeliosCustomersConsts.LocalizationSourceName;
        }
    }
}
