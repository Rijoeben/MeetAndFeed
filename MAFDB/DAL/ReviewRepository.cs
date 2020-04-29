using MAFDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly MeetAndFeedDbContext ctx;

        public ReviewRepository()
        {
            ctx = new MeetAndFeedDbContext();
        }

        public IEnumerable<Review> ReadReview()
        {
            return ctx.Reviews.AsEnumerable();
        }
        public Review AddReview(Review review)
        {
            ctx.Add(review);
            ctx.SaveChanges();
            return review;
        }

        public void UpdateReview(Review review)
        {
            ctx.Add(review);
            ctx.SaveChanges();
        }

        public void DeleteReview(Review review)
        {
            ctx.Remove(review);
            ctx.SaveChanges();
        }

        public Review GetReview(long reviewId)
        {
            return ctx.Reviews.Find(reviewId);
        }
    }
}
