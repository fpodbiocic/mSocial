using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            [Required(ErrorMessage = "Tweet content is required.")]
            [MaxLength(280, ErrorMessage = "The tweet shouldn't have more than 280 characters.")]
            [MinLength(1, ErrorMessage = "The tweet should have more than 1 character.")]
            public string Body { get; set; }
        }
    }
}
