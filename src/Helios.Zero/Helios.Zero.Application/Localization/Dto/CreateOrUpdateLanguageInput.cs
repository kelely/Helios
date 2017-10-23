using System.ComponentModel.DataAnnotations;

namespace Helios.Zero.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}