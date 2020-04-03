using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
        public interface IReviewRepository
        {
            IEnumerable<Review> ReadReview();

            Review CreateReview(Review review);

            void UpdateReview(Review review);

            void DeleteReview(Review review);
        }
}
