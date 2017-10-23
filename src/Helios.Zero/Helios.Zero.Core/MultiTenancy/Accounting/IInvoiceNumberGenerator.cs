using System.Threading.Tasks;
using Abp.Dependency;

namespace Helios.Zero.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}