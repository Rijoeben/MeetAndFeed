using System.Collections.Generic;
using MAFDB;

namespace DAL
{
        public interface IReviewRepository
        {
            IEnumerable<Review> ReadReview();
            Review AddReview(Review review);
            void UpdateReview(Review review);
            void DeleteReview(Review review);
            Review GetReview(long reviewId);
        }
}
