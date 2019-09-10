using System;
using System.Collections.Generic;

namespace mTwitter.API.Models.DatabaseModels.mTwitter
{
    public partial class Role
    {
        public Role()
        {
            ApplicationUser = new HashSet<ApplicationUser>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}
