using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static mTwitter.API.Models.PostModel;

namespace mTwitter.API.Services
{
    public interface ImTwitterRepository
    {
        IEnumerable<PostDTO> GetPosts();
    }
}
