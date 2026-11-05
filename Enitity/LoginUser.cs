using System.ComponentModel.DataAnnotations;

namespace Enitity
{
    public class LoginUser
    {
        [EmailAddress]

        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
