using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static mTwitter.API.Models.PostModel;

namespace mTwitter.API.Services
{
    public interface IPostService
    {
        IEnumerable<PostDTO> GetPosts();
        PostDTO GetPost(Guid id);
        PostDTO GetPost(Guid ownerId, Guid id);
        IEnumerable<PostDTO> GetPostsByOwnerId(Guid ownerId);
        PostDTO AddPost(Guid ownerId, PostPostDTO post);
        void DeletePost(PostDTO post);
        bool Save();
    }
}
