using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        public IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var reviews = _reviewService.ListOfReviews();
            if (reviews == null) return NotFound();
            return Ok(reviews);
        }
        [HttpGet("{Id}")]
        public IActionResult GetReviewById(long Id)
        {
            var review = _reviewService.ReadReview(Id);
            if (review == null) return NotFound();
            return Ok(review);
        }

        [HttpPost]
        public IActionResult MakeReview(string content, float score, long userId)
        {
            var reviewToAdd = _reviewService.CreateReview(content, score, userId);

            return Ok(reviewToAdd);
        }
    }
}