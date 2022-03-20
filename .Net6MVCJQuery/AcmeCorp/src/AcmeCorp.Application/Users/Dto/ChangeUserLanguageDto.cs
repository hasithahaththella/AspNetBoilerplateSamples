using System.ComponentModel.DataAnnotations;

namespace AcmeCorp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}