using mTwitter.API.Models.DatabaseModels.mTwitter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mTwitter.API.Models
{
    public class UserModel
    {
        public class UserDTO
        {
            public Guid Id { get; set; }
            public string DisplayName { get; set; }
            public string Email { get; set; }
            public Role Role { get; set; }
            public string Token { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime CreatedOn { get; set; }
        }

        public class UserPostRegDTO
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string PhoneNumber { get; set; }
        }

        public class UserPostAuthDTO
        {
            [Required(ErrorMessage = "Email is required")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            public string Password { get; set; }
        }
    }
}
