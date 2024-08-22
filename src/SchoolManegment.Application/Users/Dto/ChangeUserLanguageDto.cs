using System.ComponentModel.DataAnnotations;

namespace SchoolManegment.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}