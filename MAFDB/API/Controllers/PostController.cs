﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BL;
using MAFDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")] 
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostService _postService;
        //private IReviewService _reviewService; //meerdere services in 1 controller, waarom niet? kutding
        public PostController(IPostService postService/*,IReviewService reviewService*/)
        {
            _postService = postService;
            //_reviewService = reviewService;
        }
        [HttpGet]
        public IActionResult GetListOfPosts()
        {
            var posts = _postService.ListOfPosts();
            if (posts == null) return NotFound();
            return Ok(posts);
        }

        [HttpGet("{Id}")]    
        public IActionResult GetPostByID(long Id)
        {
            var post = _postService.ReadPost(Id);
          
            
            return Ok(post);
        }
        [HttpPost]
        public IActionResult AddingPost(string chef, string dish, string description, DateTime date, int amountOfPeople, long userId)
        {
            var newPost = _postService.CreatePost(chef, dish, description, date, amountOfPeople,userId);
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
        [HttpPut("{revId},{postId}")]
        public IActionResult AppendReview(long revId,long postId)
        {
            //catch -> 
            var reviewToAppend = _postService.AddingReview(revId, postId);
            return Ok(reviewToAppend);
        }

        //[HttpPut]
        //public IActionResult AddReviewToPost(long userid, string content,float score)
        //{
        //    var reviewtoadd = _reviewService.CreateReview(content, score);
        //    return Ok(reviewtoadd);
        //}
        [HttpDelete]
        public IActionResult DeletePost(long postId)
        {
            _postService.RemovePost(postId);
            return Ok(postId);
        }
    }
}