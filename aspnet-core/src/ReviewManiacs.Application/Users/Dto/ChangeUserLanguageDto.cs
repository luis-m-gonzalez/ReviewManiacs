using System.ComponentModel.DataAnnotations;

namespace ReviewManiacs.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}