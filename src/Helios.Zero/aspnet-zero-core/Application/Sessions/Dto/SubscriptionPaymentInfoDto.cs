using Abp.AutoMapper;
using Helios.MultiTenancy.Payments;

namespace Helios.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}