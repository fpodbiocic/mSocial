using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mTwitter.API.Models
{
    public class PostModel
    {
        public class PostDTO
        {
            public Guid Id { get; set; }
            public string Body { get; set; }
            public int? Likes { get; set; }
            public int? Comments { get; set; }
            public int? Retweets { get; set; }
            public string CreatedBy { get; set; }
            public DateTime CreatedOn { get; set; }
        }

        public class PostPostDTO
        {
            public string Body { get; set; }
        }
    }
}
