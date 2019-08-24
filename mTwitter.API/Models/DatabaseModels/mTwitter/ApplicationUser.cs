using System;
using System.Collections.Generic;

namespace mTwitter.API.Models.DatabaseModels.mTwitter
{
    public partial class ApplicationUser
    {
        public ApplicationUser()
        {
            Post = new HashSet<Post>();
            Profile = new HashSet<Profile>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid RoleId { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
    }
}
