using System.ComponentModel.DataAnnotations;
using Helios.Zero.Authorization.Users;

namespace Helios.Zero.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}