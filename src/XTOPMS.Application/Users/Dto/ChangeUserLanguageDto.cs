using System.ComponentModel.DataAnnotations;

namespace XTOPMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}