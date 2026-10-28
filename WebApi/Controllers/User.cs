using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers
{
    //User is a model, not a controller. It usually lives in a Models folder (Models/User.cs)
    //In C#, public properties are written in PascalCase (Name, LastName, Email, Password, Id).
    //If you rename them, users.txt still has the old names, so read it with
    //new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
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
