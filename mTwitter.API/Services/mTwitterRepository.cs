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

        public PostDTO GetPost(Guid id)
        {
            PostDTO post = _context.Post
                .Where(p => p.Id == id && p.IsDeleted == false)
                .Select(p => new PostDTO()
                {
                    Id = p.Id,
                    Body = p.Body,
                    Likes = p.Likes,
                    Comments = p.Comments,
                    Retweets = p.Retweets,
                    CreatedBy = p.CreatedBy,
                    CreatedOn = p.CreatedOn
                })
                .FirstOrDefault();

            return post;
        }

        public PostDTO GetPost(Guid ownerId, Guid id)
        {
            PostDTO post = _context.Post
                .Where(p => p.Id == id && p.OwnerId == ownerId && p.IsDeleted == false)
                .Select(p => new PostDTO()
                {
                    Id = p.Id,
                    Body = p.Body,
                    Likes = p.Likes,
                    Comments = p.Comments,
                    Retweets = p.Retweets,
                    CreatedBy = p.CreatedBy,
                    CreatedOn = p.CreatedOn
                })
                .FirstOrDefault();

            return post;
        }

        public IEnumerable<PostDTO> GetPosts()
        {
            IQueryable<PostDTO> posts = from p in _context.Post

                                        where p.IsDeleted == false

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

            return posts.ToList().OrderBy(p => p.CreatedOn);
        }

        public IEnumerable<PostDTO> GetPostsByOwnerId(Guid ownerId)
        {
            IQueryable<PostDTO> posts = from p in _context.Post

                                        where p.IsDeleted == false
                                        where p.OwnerId == ownerId

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

        public PostDTO AddPost(Guid ownerId, PostPostDTO post)
        {
            Post p = new Post()
            {
                Id = Guid.NewGuid(),
                OwnerId = ownerId,
                Body = post.Body,
                Likes = 0,
                Comments = 0,
                Retweets = 0,
                IsDeleted = false,
                ModifiedBy = "Marko Vidaković",
                ModifiedOn = DateTime.Now,
                CreatedBy = "Marko Vidaković",
                CreatedOn = DateTime.Now
            };

            _context.Post.Add(p);

            return new PostDTO()
            {
                Id = p.Id,
                Body = p.Body,
                Likes = p.Likes,
                Comments = p.Comments,
                Retweets = p.Retweets,
                CreatedBy = p.CreatedBy,
                CreatedOn = p.CreatedOn
            };
        }

        public void DeletePost(PostDTO post)
        {
            _context.Post.Remove(_context.Post.Where(p => p.Id == post.Id && p.IsDeleted == false).SingleOrDefault());
            _context.SaveChanges();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
