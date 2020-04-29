using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        public IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("{Id}")]
        public IActionResult GetReviewById(long Id)
        {
            var review = _reviewService.ReadReview(Id);
            if (review == null) return NotFound();
            return Ok(review);
        }
    
        [HttpPost]
        public IActionResult MakeReview(string content, float score, long userId, long postId)
        {
            var reviewToAdd = _reviewService.CreateReview(content, score);

            return Ok(reviewToAdd);
        }
    }
}