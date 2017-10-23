using System.ComponentModel.DataAnnotations;
using Abp.Notifications;

namespace Helios.Zero.Notifications.Dto
{
    public class NotificationSubscriptionDto
    {
        [Required]
        [MaxLength(NotificationInfo.MaxNotificationNameLength)]
        public string Name { get; set; }

        public bool IsSubscribed { get; set; }
    }
}