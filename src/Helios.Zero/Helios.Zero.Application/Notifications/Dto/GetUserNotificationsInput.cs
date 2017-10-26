using Abp.Notifications;
using Helios.Dto;

namespace Helios.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}