using System;
using System.Text;
using Abp.Domain.Entities;

// ReSharper disable once CheckNamespace
namespace Helios.Orders
{
    public class SalesOrderLine : Entity<Guid>
    {
        /// <summary>
        /// 订单条目对应的商品Id(某产品，某服务，指代一切可销售的事物Id)
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        /// 订单条目销售商品小计
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public int UnitPrice { get; set; }
    }
}
