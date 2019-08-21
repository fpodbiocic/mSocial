using mTwitter.API.Models;
using mTwitter.API.Models.DatabaseModels.mTwitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static mTwitter.API.Models.PostModel;

namespace mTwitter.API.Services
{
    public class mTwitterRepository : ImTwitterRepository
    {
        private readonly mTwitterContext _context;

        public mTwitterRepository(mTwitterContext context)
        {
            _context = context;
        }

        public IEnumerable<PostDTO> GetPosts()
        {
            IQueryable<PostDTO> posts = from p in _context.Post
                                        select new PostDTO()
                                        {
                                            Id = p.Id,
                                            Body = p.Body,
                                            Likes = p.Likes,
                                            Comments = p.Comments,
                                            Retweets = p.Retweets,
                                            CreatedBy = p.CreatedBy,
                                            CreatedOn = p.CreatedOn
                                        };

            return posts.ToList();
        }
    }
}
