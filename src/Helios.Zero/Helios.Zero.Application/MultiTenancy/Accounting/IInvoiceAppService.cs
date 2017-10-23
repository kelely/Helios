using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Helios.Zero.MultiTenancy.Accounting.Dto;

namespace Helios.Zero.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
