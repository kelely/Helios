using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

// ReSharper disable once CheckNamespace
namespace Helios.Orders
{
    /// <summary>
    /// 销售单实体
    /// </summary>
    public class SalesOrder : FullAuditedAggregateRoot<Guid>, IMustHaveTenant, ISoftDelete, ICreationAudited
    {
        public const int MaxCommentLength = 512;

        public SalesOrder()
        {
            this.Lines = new List<SalesOrderLine>();
        }

        /// <summary>
        /// 订单关联的租户Id
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// 客户Id
        /// </summary>
        /// <remarks>在某些支持代客下单的系统中，下单用户Id不一定就是客户Id</remarks>
        public int CustomerId { get; protected set; }

        /// <summary>
        /// 订单总计金额(应付金额)
        /// </summary>
        public int TotalAmount { get; protected set; }

        /// <summary>
        /// 订单总计金额(实际支付)
        /// </summary>
        public int ActualAmount { get; protected set; }

        /// <summary>
        /// 订单总计优惠金额(减免金额)
        /// </summary>
        public int DiscountAmount { get; protected set; }

        /// <summary>
        /// 包含一个或多个订单明细条目的订单明细表
        /// </summary>
        public ICollection<SalesOrderLine> Lines { get; }

        /// <summary>
        /// 订单状态值
        /// </summary>
        public int OrderStatus { get; protected set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [MaxLength(MaxCommentLength)]
        public string Comment { get; set; }

        public void AddLine(SalesOrderLine line, ISalesOrderPolicy salesOrderPolicy)
        {
            salesOrderPolicy.CheckIfCanAddLineToOrder(this, line);

            this.Lines.Add(line);
        }
    }
}