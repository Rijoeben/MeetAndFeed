using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using MAFDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostService _postService;
        
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        public IActionResult GetListOfPosts()
        {
            var posts = _postService.ListOfPosts();
            if (posts == null) return NotFound();
            return Ok(posts);
        }
        [HttpPut]
        public IActionResult PutPost(string dish, string description, DateTime date, int amountOfPeople)//long userId)
        {
            var newPost = _postService.CreatePost(dish, description, date, amountOfPeople);
            return Ok(newPost);
        }
    }
}