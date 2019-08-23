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
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            IEnumerable<PostDTO> posts = _postService.GetPosts();

            if (posts == null)
            {
                return NotFound();
            }

            return Ok(posts);
        }

        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetPost(Guid id)
        {
            PostDTO post = _postService.GetPost(id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        [HttpGet("ByOwnerId/{ownerId}")]
        public IActionResult GetPostsByOwnerId(Guid ownerId)
        {
            IEnumerable<PostDTO> posts = _postService.GetPostsByOwnerId(ownerId);

            if (posts == null)
            {
                return NotFound();
            }

            return Ok(posts);
        }

        [HttpPost("{ownerId}")]
        public IActionResult AddPost(Guid ownerId, [FromBody] PostPostDTO post)
        {
            if(post == null)
            {
                return BadRequest();
            }

            // Model state is a Dictionary - the property IsValid will be false if the requirements on the PostPostDTO are not met
            if (!ModelState.IsValid)
            {
                // return 422
                return new UnprocessableEntityObjectResult(ModelState);
            }

            PostDTO pdto = _postService.AddPost(ownerId, post);

            if (!_postService.Save())
            {
                return StatusCode(500);
            }

            return CreatedAtRoute("GetPost", new { id = pdto.Id }, pdto);
        }

        [HttpDelete("{ownerId}/{id}")]
        public IActionResult DeletePost(Guid ownerId, Guid id)
        {
            PostDTO pdto = _postService.GetPost(ownerId, id);

            if(pdto == null)
            {
                return NotFound();
            }

            _postService.DeletePost(pdto);

            return NoContent();
        }
    }
}