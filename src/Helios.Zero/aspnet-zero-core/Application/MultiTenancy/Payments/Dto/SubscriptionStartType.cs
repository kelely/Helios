// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy.Payments.Dto
{
    /// <summary>
    /// 软件服务订阅类型
    /// </summary>
    public enum SubscriptionStartType
    {
        /// <summary>
        /// 免费使用
        /// </summary>
        Free = 1,

        /// <summary>
        /// 免费试用
        /// </summary>
        Trial = 2,

        /// <summary>
        /// 付款使用
        /// </summary>
        Paid = 3
    }
}