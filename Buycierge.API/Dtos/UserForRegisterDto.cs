using System.ComponentModel.DataAnnotations;

namespace Buycierge.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }   

        [Required] 
        [StringLength(8,MinimumLength = 4, ErrorMessage = "You must specifiy passwords between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}