using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mTwitter.API.Services;
using static mTwitter.API.Models.PostModel;

namespace mTwitter.API.Controllers
{
    [Route("api/Posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ImTwitterRepository _repository;

        public PostsController(ImTwitterRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<PostDTO> posts = _repository.GetPosts();

            if(posts == null)
            {
                return NotFound();
            }

            return Ok(posts);
        }
    }
}