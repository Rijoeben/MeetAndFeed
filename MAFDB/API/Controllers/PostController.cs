using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        [HttpGet("{id}")]     /*!Vragen!*/
        public IActionResult GetPostByID(long Id)
        {
            var post = _postService.ReadPost(Id);
          
            
            return Ok(post);
        }
        [HttpPost]
        public IActionResult AddingPost(string dish, string description, DateTime date, int amountOfPeople)//long userId)
        {
            var newPost = _postService.CreatePost(dish, description, date, amountOfPeople);
            return Ok(newPost);
        }
        [HttpPut]
        public IActionResult UpdatePost(string dish, string description, DateTime date, int amountOfPeople, long postId)
        {
            var postToChange = _postService.ReadPost(postId);
            if(postToChange != null)
            {
                postToChange = _postService.ChangePost(dish, description, date, amountOfPeople, postId);

                return Ok(postToChange);
            }

            return NotFound();
        }
        [HttpDelete]
        public IActionResult DeletePost(long postId)
        {
            _postService.RemovePost(postId);
            return Ok(postId);
        }

    }
}