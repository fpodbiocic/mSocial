using System;
using System.Collections.Generic;

namespace mTwitter.API.Models.DatabaseModels.mTwitter
{
    public partial class Profile
    {
        public Guid Id { get; set; }
        public string Handle { get; set; }
        public string Picture { get; set; }
        public int Following { get; set; }
        public int Followers { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Bio { get; set; }
        public string Website { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
