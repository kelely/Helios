using System.ComponentModel.DataAnnotations;

namespace Helios.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
