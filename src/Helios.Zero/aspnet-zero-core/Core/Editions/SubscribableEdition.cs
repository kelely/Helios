using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Application.Editions;
using Helios.MultiTenancy.Payments;

// ReSharper disable once CheckNamespace
namespace Helios.Editions
{
    /// <summary>
    /// Extends <see cref="Edition"/> to add subscription features.
    /// 版本实体
    /// </summary>
    public class SubscribableEdition : Edition
    {
        /// <summary>
        /// The edition that will assigned after expire date
        /// 本版将分配后的到期日期
        /// </summary>
        public int? ExpiringEditionId { get; set; }

        /// <summary>
        /// 逐月支付金额
        /// </summary>
        public decimal? MonthlyPrice { get; set; }

        /// <summary>
        /// 包年支付金额
        /// </summary>
        public decimal? AnnualPrice { get; set; }

        /// <summary>
        /// 可试用天数
        /// </summary>
        public int? TrialDayCount { get; set; }

        /// <summary>
        /// The account will be taken an action (termination of tenant account) after the specified days when the subscription is expired.
        /// 该帐户将在认购期满后的某一天采取行动（承租人帐户终止）。
        /// </summary>
        public int? WaitingDayAfterExpire { get; set; }

        [NotMapped]
        public bool IsFree => !MonthlyPrice.HasValue && !AnnualPrice.HasValue;

        /// <summary>
        /// 版本是否有试用期
        /// </summary>
        /// <returns></returns>
        public bool HasTrial()
        {
            if (IsFree)
            {
                return false;
            }

            return TrialDayCount.HasValue && TrialDayCount.Value > 0;
        }

        /// <summary>
        /// 获取该版本在指定的支付方式情况下需要支付的金额
        /// </summary>
        /// <param name="paymentPeriodType"></param>
        /// <returns></returns>
        public decimal GetPaymentAmount(PaymentPeriodType? paymentPeriodType)
        {
            if (MonthlyPrice == null || AnnualPrice == null)
            {
                throw new Exception("No price information found for " + DisplayName + " edition!");
            }

            switch (paymentPeriodType)
            {
                case PaymentPeriodType.Monthly:
                    return MonthlyPrice.Value;
                case PaymentPeriodType.Annual:
                    return AnnualPrice.Value;
                default:
                    throw new Exception("Edition does not support payment type: " + paymentPeriodType);
            }
        }

        /// <summary>
        /// 对比两个版本是否有完全一致的付款计划(金额)
        /// </summary>
        /// <param name="edition"></param>
        /// <returns></returns>
        public bool HasSamePrice(SubscribableEdition edition)
        {
            return !IsFree &&
                   MonthlyPrice == edition.MonthlyPrice && AnnualPrice == edition.AnnualPrice;
        }
    }
}