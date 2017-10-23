using Abp.AutoMapper;
using Helios.Zero.MultiTenancy.Payments;

namespace Helios.Zero.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}