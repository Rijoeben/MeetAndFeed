using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;
using DAL;

namespace BL
{
    public class ReviewService : IReviewService
    {
        private IReviewRepository _repo;

        public Review ChangeReview(long reviewId, string content, float score)
        {
            Review reviewToChange = ReadReview(reviewId);

            if(reviewToChange != null)
            {
                reviewToChange.Content = content;
                reviewToChange.Score = score;

                _repo.UpdateReview(reviewToChange);
                return reviewToChange;
            }
            else
            {
                return null;
            }          
            
        }
        public Review CreateReview(string content, float score)
        {
            Review newReview = new Review();

            newReview.Content = content;
            newReview.Score = score;            

            _repo.AddReview(newReview);
            return newReview;
        }
        public Review ReadReview(long reviewId)
        {
            return _repo.GetReview(reviewId);

        }
    }
}
