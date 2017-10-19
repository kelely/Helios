using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

// ReSharper disable once CheckNamespace
namespace Helios.Orders.Dto
{
    [AutoMap(typeof(SalesOrder))]
    public class SalesOrderDto : EntityDto<Guid>
    {
        /// <summary>
        /// 订单流水号(租户唯一)
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 下单客户Id
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [MaxLength(SalesOrder.MaxCommentLength)]
        public string Comment { get; set; }

        /// <summary>
        /// 订单总金额(下单金额)
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 订单实际总金额(实际金额)
        /// 比如订五斤萝卜三块一斤价格就十五，但分拣的时候只有四斤九两实际价格就14.5
        /// </summary>
        public decimal? ActualAmount { get; set; }

        /// <summary>
        /// 订单总优惠金额
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// 付款标识, true - 已付款, false - 未付款
        /// </summary>
        public bool Paid { get; set; }

        /// <summary>
        /// 订单创建的时间(下单时间)
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
