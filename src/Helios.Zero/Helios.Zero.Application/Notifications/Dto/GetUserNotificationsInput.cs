using Abp.Notifications;
using Helios.Zero.Dto;

namespace Helios.Zero.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}