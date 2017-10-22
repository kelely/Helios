using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Helios.Authorization.Users;
using Helios.MultiTenancy;

// ReSharper disable once CheckNamespace
namespace Helios.Notifications
{
    public partial interface IAppNotifier
    {
        /// <summary>
        /// 向指定用户发送欢迎通知
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        /// <summary>
        /// 发送新租户注册消息
        /// </summary>
        /// <param name="tenant"></param>
        /// <returns></returns>
        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
