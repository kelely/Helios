// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy.Payments
{
    /// <summary>
    /// 租户进行软件服务费的支付周期类型
    /// </summary>
    public enum PaymentPeriodType
    {
        /// <summary>
        /// 月付
        /// </summary>
        Monthly = 30,

        /// <summary>
        /// 年付
        /// </summary>
        Annual = 365
    }
}