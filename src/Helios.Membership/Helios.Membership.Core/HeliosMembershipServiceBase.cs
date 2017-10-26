using Abp;

namespace Helios.Membership
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="HeliosMembershipDomainServiceBase"/>.
    /// For application services inherit <see cref="HeliosMembershipServiceBase"/>.
    /// </summary>
    public abstract class HeliosMembershipServiceBase : AbpServiceBase
    {
        protected HeliosMembershipServiceBase()
        {
            LocalizationSourceName = HeliosMembershipConsts.LocalizationSourceName;
        }
    }
}