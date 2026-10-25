using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers
{
    public class User
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string lastName { get; set; }

        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public int id { get; set; }
    }
}
