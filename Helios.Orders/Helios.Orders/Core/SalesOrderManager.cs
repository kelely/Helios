using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

// ReSharper disable once CheckNamespace
namespace Helios.Orders
{
    /// <summary>
    /// 销售单领域服务
    /// </summary>
    public sealed class SalesOrderManager : DomainService, ISalesOrderManager
    {
        private readonly IRepository<SalesOrder, Guid> _repository;

        public SalesOrderManager(IRepository<SalesOrder, Guid> repository)
        {
            _repository = repository;
        }

        public Task<SalesOrder> FindByIdAsync(Guid id)
        {
            return this._repository.GetAsync(id);
        }
    }
}
