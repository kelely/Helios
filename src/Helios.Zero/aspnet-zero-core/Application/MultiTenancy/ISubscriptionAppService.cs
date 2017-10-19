using System.Threading.Tasks;
using Abp.Application.Services;

namespace Helios.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
