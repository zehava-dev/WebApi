using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Enitity
{
    public class User
    {

        [Required]
        //In C#, properties are written in PascalCase: Name. users.txt stores the current names: if you rename them, set PropertyNameCaseInsensitive = true in the JsonSerializerOptions, so the existing file still loads
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
