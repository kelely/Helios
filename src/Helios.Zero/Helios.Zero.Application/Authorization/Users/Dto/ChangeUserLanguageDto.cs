using System.ComponentModel.DataAnnotations;

namespace Helios.Zero.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
