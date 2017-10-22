// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy.Dto
{
    /// <summary>
    /// 租户注册返回结果对象
    /// </summary>
    public class RegisterTenantOutput
    {
        /// <summary>
        /// 租户Id
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// 租户标识名称(域名规则)
        /// </summary>
        public string TenancyName { get; set; }

        /// <summary>
        /// 租户名称(可中文)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 管理员用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 管理员电子邮件地址
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 租户是否已经激活
        /// </summary>
        public bool IsTenantActive { get; set; }

        /// <summary>
        /// 用户是否已经激活可用
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 是否需要邮件确认
        /// </summary>
        public bool IsEmailConfirmationRequired { get; set; }
    }
}