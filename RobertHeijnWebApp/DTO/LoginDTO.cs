using System.ComponentModel.DataAnnotations;

namespace RobertHeijnWebApp.Pages
{
    public class LoginDTO
    {
        public LoginDTO()
        {
        }

        [Required]
        [StringLength(50, ErrorMessage = "The minimum allowed length is 1 characters.", MinimumLength = 1)]
        public string UserName { get ; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get ; set; }
        
    }
}
