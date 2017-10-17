using System;
using System.Threading.Tasks;
using Abp.Domain.Services;

// ReSharper disable once CheckNamespace
namespace Helios.Orders
{
    /// <summary>
    /// 销售单领域服务接口
    /// </summary>
    public interface ISalesOrderManager : IDomainService
    {
        Task<SalesOrder> FindByIdAsync(Guid orderId);
    }
}