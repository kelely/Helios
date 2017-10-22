using System.Threading.Tasks;
using Abp.Domain.Repositories;

// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy.Payments
{
    public partial interface ISubscriptionPaymentRepository : IRepository<SubscriptionPayment, long>
    {
        /// <summary>
        /// 更新付款单状态
        /// </summary>
        /// <param name="gateway"></param>
        /// <param name="paymentId"></param>
        /// <param name="tenantId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<SubscriptionPayment> UpdateByGatewayAndPaymentIdAsync(SubscriptionPaymentGatewayType gateway, string paymentId, int? tenantId, SubscriptionPaymentStatus status);

        /// <summary>
        /// 获取付款单
        /// </summary>
        /// <param name="gateway"></param>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        Task<SubscriptionPayment> GetByGatewayAndPaymentIdAsync(SubscriptionPaymentGatewayType gateway, string paymentId);
    }
}
