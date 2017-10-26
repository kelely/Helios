using System.ComponentModel.DataAnnotations;
using Helios.Authorization.Users;

namespace Helios.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}