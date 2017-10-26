using System.Threading.Tasks;
using Abp.Dependency;

namespace Helios.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}