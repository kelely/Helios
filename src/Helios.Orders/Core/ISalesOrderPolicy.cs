using System;
using System.Collections.Generic;
using System.Text;
using Abp.UI;

// ReSharper disable once CheckNamespace
namespace Helios.Orders
{
    /// <summary>
    /// 销售单策略接口定义
    /// </summary>
    public interface ISalesOrderPolicy
    {
        /// <summary>
        /// 检查是否允许添加订单子项到订单
        /// </summary>
        /// <param name="order"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        void CheckIfCanAddLineToOrder(SalesOrder order, SalesOrderLine line);
    }

    public class SalesOrderPolicy : ISalesOrderPolicy
    {
        public void CheckIfCanAddLineToOrder(SalesOrder order, SalesOrderLine line)
        {
            if(order.Lines.Count > 0)
                throw new UserFriendlyException("订单明细太多了，不允许增加新的条目了");
        }
    }
}
