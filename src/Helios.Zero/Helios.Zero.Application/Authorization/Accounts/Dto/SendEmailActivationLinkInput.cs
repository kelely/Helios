using System.ComponentModel.DataAnnotations;

namespace Helios.Zero.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}