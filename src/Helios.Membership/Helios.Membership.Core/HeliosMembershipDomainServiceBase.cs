using Abp.Domain.Services;

namespace Helios.Membership
{
    public abstract class HeliosMembershipDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected HeliosMembershipDomainServiceBase()
        {
            LocalizationSourceName = HeliosMembershipConsts.LocalizationSourceName;
        }
    }
}
