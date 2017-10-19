using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Helios.Orders.Dto;

// ReSharper disable once CheckNamespace
namespace Helios.Orders
{
    public interface IOrderAsyncCrudAppService : IAsyncCrudAppService<SalesOrderDto, Guid>
    {
    }

    public class OrderAsyncCrudAppService : AsyncCrudAppService<SalesOrder, SalesOrderDto, Guid>, IOrderAsyncCrudAppService
    {
        public OrderAsyncCrudAppService(IRepository<SalesOrder, Guid> repository) : base(repository)
        {
        }
    }
}
