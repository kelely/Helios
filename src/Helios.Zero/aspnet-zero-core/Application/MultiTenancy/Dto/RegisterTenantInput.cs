using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Helios.MultiTenancy.Payments;
using Helios.MultiTenancy.Payments.Dto;

// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy.Dto
{
    public class RegisterTenantInput
    {
        /// <summary>
        /// 租户识别名称(符合子域名规则)
        /// </summary>
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 管理员邮箱地址
        /// </summary>
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        /// <summary>
        /// 管理员密码
        /// </summary>
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        public string AdminPassword { get; set; }

        /// <summary>
        /// 图形验证码
        /// </summary>
        [DisableAuditing]
        public string CaptchaResponse { get; set; }

        /// <summary>
        /// 订阅类型
        /// </summary>
        public SubscriptionStartType SubscriptionStartType { get; set; }

        /// <summary>
        /// 订阅软件服务时的付款网关
        /// </summary>
        public SubscriptionPaymentGatewayType? Gateway { get; set; }

        /// <summary>
        /// 订阅的版本
        /// </summary>
        public int? EditionId { get; set; }

        public string PaymentId { get; set; }
    }
}