using System.ComponentModel.DataAnnotations;

namespace RobertHeijnWebApp.Pages
{
    public class MemberRegister
    {
        private string username;
        private string password;
        private string firstname;
        private string lastname;
        private string email;
        private string address;
        private string nickname;
        private string biography;

        public MemberRegister()
        {

        }
        [RegularExpression("[a-zA-Z0-9]*",
                           ErrorMessage = "The name can only contain numbers and digits.")]
        public string Username { get => username; set => username = value; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        [Required]
        [StringLength(50, ErrorMessage = "The minimum allowed length is 1 characters.", MinimumLength = 1)]
        public string Firstname { get => firstname; set => firstname = value; }
        [Required]
        [StringLength(50, ErrorMessage = "The minimum allowed length is 1 characters.", MinimumLength = 1)]
        public string Lastname { get => lastname; set => lastname = value; }
        [Required]
        [EmailAddress(ErrorMessage = " Invalid e-mail adress.")]
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Biography { get => biography; set => biography = value; }
    }
}

