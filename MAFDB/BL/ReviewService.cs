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

        public Review CreateReview(string content)
        {
            Review newReview = new Review();

            newReview.Content = content;

            _repo.AddReview(newReview);
            return newReview;
        }
    }
}
