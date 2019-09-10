using System;
using System.Collections.Generic;

namespace mTwitter.API.Models.DatabaseModels.mTwitter
{
    public partial class Post
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string Body { get; set; }
        public int? Likes { get; set; }
        public int? Comments { get; set; }
        public int? Retweets { get; set; }
        public bool? IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ApplicationUser Owner { get; set; }
    }
}
